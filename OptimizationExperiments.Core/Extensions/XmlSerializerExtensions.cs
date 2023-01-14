namespace OptimizationExperiments.Core.Extensions;

public static class XmlSerializerExtensions
{
    private const int EncodeUtf8 = 65001;

    public static T? XmlDeserialize<T>(this string xmlSource, string? rootElementName = null)
        where T : class
    {
        var xmlRootAttribute = rootElementName is null
            ? null
            : new XmlRootAttribute(rootElementName);

        var xmlSerializer = new XmlSerializer(typeof(T), xmlRootAttribute);
        using var reader = new StringReader(xmlSource);

        return xmlSerializer.Deserialize(reader) as T;
    }

    public static string XmlSerialize<T>(T model, int encodingCode = EncodeUtf8, bool deleteOther = false, string rootName = "Root")
    {
        XmlSerializerNamespaces? xmlSerializerNamespaces = default;

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        if (!deleteOther)
        {
            xmlSerializerNamespaces = new XmlSerializerNamespaces();
            xmlSerializerNamespaces.Add(string.Empty, string.Empty);
        }

        XmlRootAttribute root = new()
        {
            ElementName = model?.GetType().GetCustomAttribute<XmlRootAttribute>(inherit: true)?.ElementName ?? rootName
        };

        using MemoryStream memoryStream = new();
        var encoding = Encoding.GetEncoding(encodingCode);
        var settings = new XmlWriterSettings
        {
            OmitXmlDeclaration = !deleteOther,
            Indent = deleteOther,
            Encoding = encoding
        };

        using var xmlWriter = XmlWriter.Create(output: memoryStream, settings);
        new XmlSerializer(type: typeof(T), root).Serialize(xmlWriter, model, xmlSerializerNamespaces);

        return encoding.GetString(bytes: memoryStream.ToArray());
    }
}