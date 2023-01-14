namespace OptimizationExperiments.Benchmark.Benchmarks.Collections.Dictionaries;

[Config(typeof(MemoryPerformanceConfig))]
public class DictionariesBenchmark
{
    private static readonly Dictionary<string, string> Dictionary = new()
    {
        { "APPLICATION_ID", "APPLICATION" },
        { "APPLICATION_DATE", "APPLICATION" },
        { "REQUEST_CHANNEL", "APPLICATION" },
        { "CH_EXIST", "APPLICATION" },
        { "CLIENT_ID", "PERSON" },
        { "SURNAME", "PERSON" },
        { "FIRSTNAME", "PERSON" },
        { "PATRONYMIC", "PERSON" },
        { "PREV_SURNAME", "PERSON" },
        { "BIRTHDATE", "PERSON" },
        { "GENDER", "PERSON" },
        { "MARITAL_STATUS", "PERSON" },
        { "BIRTHPLACE", "PERSON" },
        { "EDUCATION_LEVEL", "PERSON" },
        { "POSITION", "PERSON" },
        { "SOCIAL_STATUS", "PERSON" },
        { "SNILS", "PERSON" },
        { "INN", "PERSON" },
        { "DOC_TYPE", "DOCUMENT" },
        { "DOC_SERIES", "DOCUMENT" },
        { "DOC_NUMBER", "DOCUMENT" },
        { "DATE_OF_ISSUE", "DOCUMENT" },
        { "ISSUED_BY", "DOCUMENT" },
        { "ISSUED_AT", "DOCUMENT" },
        { "ISSUING_UNIT_CODE", "DOCUMENT" },
        { "MONTHLY_INCOME", "FINANCIAL_STANDING" },
        { "INCOME_SOURCE", "FINANCIAL_STANDING" },
        { "DEPENDANTS_CNT", "FINANCIAL_STANDING" },
        { "CHILDREN_CNT", "FINANCIAL_STANDING" },
        { "FAMILY_CNT", "FINANCIAL_STANDING" },
        { "REQUESTED_SUM", "REQUESTED_TERMS" },
        { "REQUESTED_TERM", "REQUESTED_TERMS" },
        { "REQUESTED_TERM_UOM", "REQUESTED_TERMS" },
        { "PRODUCT", "REQUESTED_TERMS" },
        { "CONSENT_GIVEN_FLAG", "CONSENT" },
        { "CONSENT_DATE", "CONSENT" },
        { "CONSENT_EXPIRE_DATE", "CONSENT" },
        { "REG_IS_FACT_FLAG", "ADDRESS" },
        { "PARENT_REG", "ADDRESS" },
        { "ADDRESS_TYPE", "ADDRESS" },
        { "ZIP", "ADDRESS" },
        { "FED_SUBJECT", "ADDRESS" },
        { "FED_SUBJECT_CODE", "ADDRESS" },
        { "DISTRICT_NAME", "ADDRESS" },
        { "CITY_NAME", "ADDRESS" },
        { "SETTLEMENT_NAME", "ADDRESS" },
        { "STREET_NAME", "ADDRESS" },
        { "BUILDING_NUMBER", "ADDRESS" },
        { "BUILDING_UNIT", "ADDRESS" },
        { "CORPUS", "ADDRESS" },
        { "INDOOR_SPACE_NUMBER", "ADDRESS" },
        { "CAT_REGION", "ADDRESS" },
        { "RESIDENTIAL_STATUS", "PERSON" },
        { "IS_SBER_CREDITS", "FINANCIAL_STANDING" },
        { "CLIENT_TYPE", "PERSON" },
        { "JUICY_ACCOUNT_ID", "APPLICATION" },
        { "COUNTRY_CODE_BILLING", "APPLICATION" },
        { "REQUEST_CHANNEL_JS", "APPLICATION" },
        { "COOKIE", "APPLICATION" },
        { "TIME_UTC3", "APPLICATION" },
        { "PH_COUNTRY", "PHONE" },
        { "PHONE_NUM", "PHONE" },
        { "PHONE_TYPE", "PHONE" },
        { "CARD_EXPIRATION_DATE", "CARD" },
        { "CARD_NUMBER", "CARD" },
        { "MAIL", "EMAIL" },
        { "IP_ADDRESS", "DEVICE" },
        { "USERAGENT", "DEVICE" },
        { "EMAIL", "EMAIL" },
        { "MOBILEPHONE", "DEVICE" },
        { "PIXEL_USER_FP", "DEVICE" },
        { "PIXEL_SESS_ID", "DEVICE" }
    };

    private static readonly StringDictionary StringDictionary = new()
    {
        { "APPLICATION_ID", "APPLICATION" },
        { "APPLICATION_DATE", "APPLICATION" },
        { "REQUEST_CHANNEL", "APPLICATION" },
        { "CH_EXIST", "APPLICATION" },
        { "CLIENT_ID", "PERSON" },
        { "SURNAME", "PERSON" },
        { "FIRSTNAME", "PERSON" },
        { "PATRONYMIC", "PERSON" },
        { "PREV_SURNAME", "PERSON" },
        { "BIRTHDATE", "PERSON" },
        { "GENDER", "PERSON" },
        { "MARITAL_STATUS", "PERSON" },
        { "BIRTHPLACE", "PERSON" },
        { "EDUCATION_LEVEL", "PERSON" },
        { "POSITION", "PERSON" },
        { "SOCIAL_STATUS", "PERSON" },
        { "SNILS", "PERSON" },
        { "INN", "PERSON" },
        { "DOC_TYPE", "DOCUMENT" },
        { "DOC_SERIES", "DOCUMENT" },
        { "DOC_NUMBER", "DOCUMENT" },
        { "DATE_OF_ISSUE", "DOCUMENT" },
        { "ISSUED_BY", "DOCUMENT" },
        { "ISSUED_AT", "DOCUMENT" },
        { "ISSUING_UNIT_CODE", "DOCUMENT" },
        { "MONTHLY_INCOME", "FINANCIAL_STANDING" },
        { "INCOME_SOURCE", "FINANCIAL_STANDING" },
        { "DEPENDANTS_CNT", "FINANCIAL_STANDING" },
        { "CHILDREN_CNT", "FINANCIAL_STANDING" },
        { "FAMILY_CNT", "FINANCIAL_STANDING" },
        { "REQUESTED_SUM", "REQUESTED_TERMS" },
        { "REQUESTED_TERM", "REQUESTED_TERMS" },
        { "REQUESTED_TERM_UOM", "REQUESTED_TERMS" },
        { "PRODUCT", "REQUESTED_TERMS" },
        { "CONSENT_GIVEN_FLAG", "CONSENT" },
        { "CONSENT_DATE", "CONSENT" },
        { "CONSENT_EXPIRE_DATE", "CONSENT" },
        { "REG_IS_FACT_FLAG", "ADDRESS" },
        { "PARENT_REG", "ADDRESS" },
        { "ADDRESS_TYPE", "ADDRESS" },
        { "ZIP", "ADDRESS" },
        { "FED_SUBJECT", "ADDRESS" },
        { "FED_SUBJECT_CODE", "ADDRESS" },
        { "DISTRICT_NAME", "ADDRESS" },
        { "CITY_NAME", "ADDRESS" },
        { "SETTLEMENT_NAME", "ADDRESS" },
        { "STREET_NAME", "ADDRESS" },
        { "BUILDING_NUMBER", "ADDRESS" },
        { "BUILDING_UNIT", "ADDRESS" },
        { "CORPUS", "ADDRESS" },
        { "INDOOR_SPACE_NUMBER", "ADDRESS" },
        { "CAT_REGION", "ADDRESS" },
        { "RESIDENTIAL_STATUS", "PERSON" },
        { "IS_SBER_CREDITS", "FINANCIAL_STANDING" },
        { "CLIENT_TYPE", "PERSON" },
        { "JUICY_ACCOUNT_ID", "APPLICATION" },
        { "COUNTRY_CODE_BILLING", "APPLICATION" },
        { "REQUEST_CHANNEL_JS", "APPLICATION" },
        { "COOKIE", "APPLICATION" },
        { "TIME_UTC3", "APPLICATION" },
        { "PH_COUNTRY", "PHONE" },
        { "PHONE_NUM", "PHONE" },
        { "PHONE_TYPE", "PHONE" },
        { "CARD_EXPIRATION_DATE", "CARD" },
        { "CARD_NUMBER", "CARD" },
        { "MAIL", "EMAIL" },
        { "IP_ADDRESS", "DEVICE" },
        { "USERAGENT", "DEVICE" },
        { "EMAIL", "EMAIL" },
        { "MOBILEPHONE", "DEVICE" },
        { "PIXEL_USER_FP", "DEVICE" },
        { "PIXEL_SESS_ID", "DEVICE" }
    };

    private static readonly Dictionary<StringValues, StringValues> DictionaryStringValues = new()
    {
        { "APPLICATION_ID", "APPLICATION" },
        { "APPLICATION_DATE", "APPLICATION" },
        { "REQUEST_CHANNEL", "APPLICATION" },
        { "CH_EXIST", "APPLICATION" },
        { "CLIENT_ID", "PERSON" },
        { "SURNAME", "PERSON" },
        { "FIRSTNAME", "PERSON" },
        { "PATRONYMIC", "PERSON" },
        { "PREV_SURNAME", "PERSON" },
        { "BIRTHDATE", "PERSON" },
        { "GENDER", "PERSON" },
        { "MARITAL_STATUS", "PERSON" },
        { "BIRTHPLACE", "PERSON" },
        { "EDUCATION_LEVEL", "PERSON" },
        { "POSITION", "PERSON" },
        { "SOCIAL_STATUS", "PERSON" },
        { "SNILS", "PERSON" },
        { "INN", "PERSON" },
        { "DOC_TYPE", "DOCUMENT" },
        { "DOC_SERIES", "DOCUMENT" },
        { "DOC_NUMBER", "DOCUMENT" },
        { "DATE_OF_ISSUE", "DOCUMENT" },
        { "ISSUED_BY", "DOCUMENT" },
        { "ISSUED_AT", "DOCUMENT" },
        { "ISSUING_UNIT_CODE", "DOCUMENT" },
        { "MONTHLY_INCOME", "FINANCIAL_STANDING" },
        { "INCOME_SOURCE", "FINANCIAL_STANDING" },
        { "DEPENDANTS_CNT", "FINANCIAL_STANDING" },
        { "CHILDREN_CNT", "FINANCIAL_STANDING" },
        { "FAMILY_CNT", "FINANCIAL_STANDING" },
        { "REQUESTED_SUM", "REQUESTED_TERMS" },
        { "REQUESTED_TERM", "REQUESTED_TERMS" },
        { "REQUESTED_TERM_UOM", "REQUESTED_TERMS" },
        { "PRODUCT", "REQUESTED_TERMS" },
        { "CONSENT_GIVEN_FLAG", "CONSENT" },
        { "CONSENT_DATE", "CONSENT" },
        { "CONSENT_EXPIRE_DATE", "CONSENT" },
        { "REG_IS_FACT_FLAG", "ADDRESS" },
        { "PARENT_REG", "ADDRESS" },
        { "ADDRESS_TYPE", "ADDRESS" },
        { "ZIP", "ADDRESS" },
        { "FED_SUBJECT", "ADDRESS" },
        { "FED_SUBJECT_CODE", "ADDRESS" },
        { "DISTRICT_NAME", "ADDRESS" },
        { "CITY_NAME", "ADDRESS" },
        { "SETTLEMENT_NAME", "ADDRESS" },
        { "STREET_NAME", "ADDRESS" },
        { "BUILDING_NUMBER", "ADDRESS" },
        { "BUILDING_UNIT", "ADDRESS" },
        { "CORPUS", "ADDRESS" },
        { "INDOOR_SPACE_NUMBER", "ADDRESS" },
        { "CAT_REGION", "ADDRESS" },
        { "RESIDENTIAL_STATUS", "PERSON" },
        { "IS_SBER_CREDITS", "FINANCIAL_STANDING" },
        { "CLIENT_TYPE", "PERSON" },
        { "JUICY_ACCOUNT_ID", "APPLICATION" },
        { "COUNTRY_CODE_BILLING", "APPLICATION" },
        { "REQUEST_CHANNEL_JS", "APPLICATION" },
        { "COOKIE", "APPLICATION" },
        { "TIME_UTC3", "APPLICATION" },
        { "PH_COUNTRY", "PHONE" },
        { "PHONE_NUM", "PHONE" },
        { "PHONE_TYPE", "PHONE" },
        { "CARD_EXPIRATION_DATE", "CARD" },
        { "CARD_NUMBER", "CARD" },
        { "MAIL", "EMAIL" },
        { "IP_ADDRESS", "DEVICE" },
        { "USERAGENT", "DEVICE" },
        { "EMAIL", "EMAIL" },
        { "MOBILEPHONE", "DEVICE" },
        { "PIXEL_USER_FP", "DEVICE" },
        { "PIXEL_SESS_ID", "DEVICE" }
    };

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("Existent key")]
    public void NativeGetValue()
    {
        var docType = Dictionary["DOC_TYPE"];
        var requestChannel = Dictionary["REQUEST_CHANNEL"];
        var phoneType = Dictionary["PHONE_TYPE"];
        var useragent = Dictionary["USERAGENT"];
        var settlementName = Dictionary["SETTLEMENT_NAME"];
    }

    [Benchmark]
    [BenchmarkCategory("Existent key")]
    public void TryGetValue()
    {
        Dictionary.TryGetValue("DOC_TYPE", out var docType);
        Dictionary.TryGetValue("REQUEST_CHANNEL", out var requestChannel);
        Dictionary.TryGetValue("PHONE_TYPE", out var phoneType);
        Dictionary.TryGetValue("USERAGENT", out var useragent);
        Dictionary.TryGetValue("SETTLEMENT_NAME", out var settlementName);
    }

    [Benchmark]
    [BenchmarkCategory("Existent key")]
    public void TryGetValueOrDefault()
    {
        var docType = Dictionary.GetValueOrDefault("DOC_TYPE");
        var requestChannel = Dictionary.GetValueOrDefault("REQUEST_CHANNEL");
        var phoneType = Dictionary.GetValueOrDefault("PHONE_TYPE");
        var useragent = Dictionary.GetValueOrDefault("USERAGENT");
        var settlementName = Dictionary.GetValueOrDefault("SETTLEMENT_NAME");
    }

    [Benchmark]
    [BenchmarkCategory("Existent key")]
    public void GetValueByMarshal()
    {
        var docType = Dictionary.GetValue("DOC_TYPE");
        var requestChannel = Dictionary.GetValue("REQUEST_CHANNEL");
        var phoneType = Dictionary.GetValue("PHONE_TYPE");
        var useragent = Dictionary.GetValue("USERAGENT");
        var settlementName = Dictionary.GetValue("SETTLEMENT_NAME");
    }

    [Benchmark]
    [BenchmarkCategory("Existent key")]
    public void NativeGetValueStringValues()
    {
        var docType = DictionaryStringValues["DOC_TYPE"];
        var requestChannel = DictionaryStringValues["REQUEST_CHANNEL"];
        var phoneType = DictionaryStringValues["PHONE_TYPE"];
        var useragent = DictionaryStringValues["USERAGENT"];
        var settlementName = DictionaryStringValues["SETTLEMENT_NAME"];
    }

    [Benchmark]
    [BenchmarkCategory("Existent key")]
    public void TryGetValueStringValues()
    {
        DictionaryStringValues.TryGetValue("DOC_TYPE", out var docType);
        DictionaryStringValues.TryGetValue("REQUEST_CHANNEL", out var requestChannel);
        DictionaryStringValues.TryGetValue("PHONE_TYPE", out var phoneType);
        DictionaryStringValues.TryGetValue("USERAGENT", out var useragent);
        DictionaryStringValues.TryGetValue("SETTLEMENT_NAME", out var settlementName);
    }

    [Benchmark]
    [BenchmarkCategory("Existent key")]
    public void TryGetValueOrDefaultStringValues()
    {
        var docType = DictionaryStringValues.GetValueOrDefault("DOC_TYPE");
        var requestChannel = DictionaryStringValues.GetValueOrDefault("REQUEST_CHANNEL");
        var phoneType = DictionaryStringValues.GetValueOrDefault("PHONE_TYPE");
        var useragent = DictionaryStringValues.GetValueOrDefault("USERAGENT");
        var settlementName = DictionaryStringValues.GetValueOrDefault("SETTLEMENT_NAME");
    }

    [Benchmark]
    [BenchmarkCategory("Existent key")]
    public void GetValueByMarshalStringValues()
    {
        var docType = DictionaryStringValues.GetValue("DOC_TYPE");
        var requestChannel = DictionaryStringValues.GetValue("REQUEST_CHANNEL");
        var phoneType = DictionaryStringValues.GetValue("PHONE_TYPE");
        var useragent = DictionaryStringValues.GetValue("USERAGENT");
        var settlementName = DictionaryStringValues.GetValue("SETTLEMENT_NAME");
    }

    [Benchmark]
    [BenchmarkCategory("Existent key")]
    public void GetValueFromStringDictionary()
    {
        var docType = StringDictionary["DOC_TYPE"];
        var requestChannel = StringDictionary["REQUEST_CHANNEL"];
        var phoneType = StringDictionary["PHONE_TYPE"];
        var useragent = StringDictionary["USERAGENT"];
        var settlementName = StringDictionary["SETTLEMENT_NAME"];
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("Non-existent key")]
    public string? NativeGetValueByNonExistent()
    {
        string? unknown;
        try
        {
            unknown = Dictionary["Unknown"];
            foreach (var coefficient in Enumerable.Range(0, 10))
                unknown = Dictionary[$"Unknown {coefficient}"];

            return unknown;
        }
        catch (KeyNotFoundException exception)
        {
            unknown = default;
            return unknown;
        }
    }

    [Benchmark]
    [BenchmarkCategory("Non-existent key")]
    public string? TryGetValueByNonExistentKey()
    {
        Dictionary.TryGetValue("Unknown", out var unknown);
        foreach (var coefficient in Enumerable.Range(0, 10))
            Dictionary.TryGetValue($"Unknown {coefficient}", out unknown);

        return unknown;
    }

    [Benchmark]
    [BenchmarkCategory("Non-existent key")]
    public string? TryGetValueOrDefaultByNonExistentKey()
    {
        var unknown = Dictionary.GetValueOrDefault("Unknown");
        foreach (var coefficient in Enumerable.Range(0, 10))
            unknown = Dictionary.GetValueOrDefault($"Unknown {coefficient}");

        return unknown;
    }

    [Benchmark]
    [BenchmarkCategory("Non-existent key")]
    public string? GetValueByMarshalByNonExistentKey()
    {
        var unknown = Dictionary.GetValue("Unknown");
        foreach (var coefficient in Enumerable.Range(0, 10))
        {
            unknown = Dictionary.GetValue($"Unknown {coefficient}");
        }

        return unknown;
    }
}