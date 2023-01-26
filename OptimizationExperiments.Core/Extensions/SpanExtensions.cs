namespace OptimizationExperiments.Core.Extensions;

public static class SpanExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ref readonly byte At(this ReadOnlySpan<byte> span, int index)
	{
		return ref Unsafe.Add(ref MemoryMarshal.GetReference(span), index);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ReadOnlySpan<byte> SliceUnsafe(this ReadOnlySpan<byte> span, int start, int length)
	{
		return MemoryMarshal.CreateReadOnlySpan(ref Unsafe.Add(ref MemoryMarshal.GetReference(span), start), length);
	}
}