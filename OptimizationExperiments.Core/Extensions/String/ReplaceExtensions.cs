namespace OptimizationExperiments.Core.Extensions.String;

public static class ReplaceExtensions
{
	public static unsafe string ReplaceMany(this string str, StringValues oldValues, StringValues newValues, int resultStringLength)
	{
		// TODO: how remove resultStringLength ?
		var oldCount = oldValues.Count;
		var newCount = newValues.Count;

		if (oldCount != newCount)
			throw new ArgumentException("Each old value must match exactly one new value");

		for (var i = 0; i < oldCount; i++)
		{
			if (string.IsNullOrEmpty(oldValues[i]))
				throw new ArgumentException("Old value may not be null or empty.", "oldValues");
			if (newValues[i] == null)
				throw new ArgumentException("New value may be null.", "newValues");
		}

		var strLen = str.Length;
		var buildSpace = resultStringLength == 0 ? strLen << 1 : resultStringLength;

		// A hand-made StringBuilder is here
		var buildArr = new char[buildSpace];

		// cached pinned pointers
		var buildHandle = GCHandle.Alloc(buildArr, GCHandleType.Pinned);
		var oldHandles = new GCHandle[oldCount];
		var newHandles = new GCHandle[newCount];
		var newLens = stackalloc int[newCount];
		var oldLens = stackalloc int[newCount];
		var oldPtrs = stackalloc char*[newCount];
		var newPtrs = stackalloc char*[newCount];
		
		// other caches
		for (var i = 0; i < oldCount; i++)
		{
			oldHandles[i] = GCHandle.Alloc(oldValues[i], GCHandleType.Pinned);
			newHandles[i] = GCHandle.Alloc(newValues[i], GCHandleType.Pinned);
			oldPtrs[i] = (char*)oldHandles[i].AddrOfPinnedObject();
			newPtrs[i] = (char*)newHandles[i].AddrOfPinnedObject();
			newLens[i] = newValues[i].Length;
			oldLens[i] = oldValues[i].Length;
		}

		var buildIndex = 0;
		fixed (char* _strFix = str)
		{
			var build = (char*)buildHandle.AddrOfPinnedObject();
			var pBuild = build;
			var pStr = _strFix;
			var endStr = pStr + strLen;
			var copyStartPos = pStr;
			while (pStr != endStr)
			{
				var find = false;
				for (var i = 0; i < oldCount; ++i)
				{
					var oldValLen = *(oldLens + i);
					
					// if the string to find does not exceed the original string
					if (oldValLen <= 0 || pStr + oldValLen > endStr)
						continue;

					var _oldFix = *(oldPtrs + i);
					// check the first char
					if (*pStr != *_oldFix)
						continue;

					// compare the rest. First, compare the second character
					find = oldValLen == 1;
					if (!find)
					{
						if (*(pStr + 1) == *(_oldFix + 1))
							find = oldValLen == 2
							       // use native memcmp function.
							       || 0 == memcmp((byte*)(pStr + 2), (byte*)(_oldFix + 2), (oldValLen - 2) << 1);
					}

					if (!find)
						continue;

					var newValLen = newLens[i];
					var newFix = newPtrs[i];
					var copyLen = (int)(pStr - copyStartPos);

					// allocate new space if needed.
					if (buildIndex + newValLen + copyLen > buildSpace)
					{
						buildHandle.Free();
						
						var oldSpace = buildSpace;
						
						buildSpace = Math.Max((int)(buildIndex + newValLen + copyLen), buildSpace << 1);
						buildArr = ExpandArray(buildArr, oldSpace, buildSpace);
						buildHandle = GCHandle.Alloc(buildArr, GCHandleType.Pinned);
						build = (char*)buildHandle.AddrOfPinnedObject();
						pBuild = build + buildIndex;
					}

					// if there is a part from the original string to copy, then do it.
					if (copyLen > 0)
					{
						memcpy((byte*)(pBuild), (byte*)copyStartPos, copyLen << 1);
						buildIndex += copyLen;
						pBuild = build + buildIndex;
					}

					// append the replacement to the builder
					memcpy((byte*)(pBuild), (byte*)newFix, newValLen << 1);
					pBuild += newValLen;
					buildIndex += newValLen;
					pStr += oldValLen;
					copyStartPos = pStr;

					// this is redutant, but brings more determinism to a method's behaviour.
					break;
				}

				// if not found, just increment the pointer within the main string
				if (!find)
					pStr++;
			}

			// if there is a part from the original string to copy, then do it.
			if (copyStartPos != pStr)
			{
				var copyLen = (int)(pStr - copyStartPos);

				// again, allocate new space if needed
				if (buildIndex + copyLen > buildSpace)
				{
					buildHandle.Free();
					
					var oldSpace = buildSpace;
					
					buildSpace = Math.Max((int)(buildIndex + copyLen), buildSpace << 1);
					buildArr = ExpandArray(buildArr, oldSpace, buildSpace);
					buildHandle = GCHandle.Alloc(buildArr, GCHandleType.Pinned);
					build = (char*)buildHandle.AddrOfPinnedObject();
					pBuild = build + buildIndex;
				}

				// append the ending
				memcpy((byte*)(pBuild), (byte*)copyStartPos, copyLen << 1);
				buildIndex += copyLen;
			}
		}

		// unpin string handles
		for (var i = 0; i < newCount; i++)
		{
			oldHandles[i].Free();
			newHandles[i].Free();
		}
		buildHandle.Free();
		return new string(buildArr, 0, buildIndex);
	}

	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern unsafe int memcmp(byte* b1, byte* b2, int count);
	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern unsafe int memcpy(byte* dest, byte* src, int count);

	private static unsafe char[] ExpandArray(char[] array, int oldSize, int newSize)
	{
		if (oldSize > newSize || oldSize > array.Length)
			throw new ArgumentOutOfRangeException();
		char[] bigger;
		bigger = new char[newSize];
		fixed (char* bpt = bigger, apt = array)
			memcpy((byte*)bpt, (byte*)apt, oldSize << 1);
		return bigger;
	}
}