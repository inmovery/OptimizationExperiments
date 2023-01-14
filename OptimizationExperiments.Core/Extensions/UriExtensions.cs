namespace OptimizationExperiments.Core.Extensions;

public static class UriExtensions
{
	public static StringValues AddQueryString(this Uri uri, IList<KeyValuePair<string, string>> queryList)
	{
		ArgumentNullException.ThrowIfNull(uri);

		var isQueryListEmpty = !queryList.Any();
		if (isQueryListEmpty)
			return uri.AbsoluteUri;

		var uriAsSpan = uri.AbsoluteUri.AsSpan();

		var summaryQueryParamsLength = queryList.Select(item => $"&{item.Key}={item.Value}".Length).Sum();

		var summaryQueryParams = string.Create(summaryQueryParamsLength, queryList, (span, list) =>
		{
			var offset = 0;
			foreach (var (key, value) in list)
			{
				if (offset > 0)
				{
					span[offset] = '&';
					offset++;
				}

				var configuredString = $"{key}={value}";

				configuredString.AsSpan().CopyTo(span[offset..]);
				offset += configuredString.Length;
			}
		});

		var connectionSign = uriAsSpan.IndexOf(value: '?') != -1 ? '&' : '?';
		var summaryQueryString = $"{uriAsSpan.ToString()}{connectionSign}{UrlEncoder.Default.Encode(summaryQueryParams)}";

		return summaryQueryString;
	}
}