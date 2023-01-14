namespace OptimizationExperiments.Benchmarks.Arrays;

[Config(typeof(MemoryPerformanceConfig))]
public class FilledArraysBenchmark
{
    //private static readonly string[] ArrayObject =
    //{
    //	"Oneawwdf vsdv;p[	",
    //	"Two aaa-++=-`",
    //	"Three awdawd0115  awde",
    //	"Four 3435(awd ",
    //	"Five awdawd541",
    //	"Six 4151351",
    //	"Oneawwdf vsdv;p[	",
    //	"Two aaa-++=-`",
    //	"Three awdawd0115  awde",
    //	"Three awdawd0115  awde",
    //	"Four 3435(awd ",
    //	"Five awdawd541",
    //	"Six 4151351",
    //	"Oneawwdf vsdv;p[	",
    //	"Two aaa-++=-`",
    //	"Three awdawd0115  awde",
    //	"Four 3435(awd ",
    //	"Five awdawd541",
    //	"Six 4151351",
    //	"Four 3435(awd ",
    //	"Five awdawd541",
    //	"Six 4151351",
    //	"Oneawwdf vsdv;p[	",
    //	"Two aaa-++=-`",
    //	"Three awdawd0115  awde",
    //	"Four 3435(awd ",
    //	"Five awdawd541",
    //	"Six 4151351",
    //	"Oneawwdf vsdv;p[	",
    //	"Two aaa-++=-`",
    //	"Three awdawd0115  awde",
    //	"Four 3435(awd ",
    //	"Five awdawd541",
    //	"Six 4151351",
    //	"Oneawwdf vsdv;p[	",
    //	"Two aaa-++=-`",
    //};

    [Benchmark(Baseline = true)]
    public string[] ReturnEmptyArray()
    {
        string[] ArrayObject =
        {
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
        };
        return ArrayObject;
    }

    [Benchmark]
    public List<string> ReturnEmptyList()
    {
        string[] ArrayObject =
        {
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
        };
        return new List<string>(ArrayObject);
    }

    [Benchmark]
    public IList<string> ReturnEmptyListInterface()
    {
        string[] ArrayObject =
        {
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
        };
        return new List<string>(ArrayObject);
    }

    [Benchmark]
    public IReadOnlyList<string> ReturnEmptyReadOnlyListInterface()
    {
        string[] ArrayObject =
        {
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
        };
        return new List<string>(ArrayObject);
    }

    [Benchmark]
    public HashSet<string> ReturnEmptyHashSet()
    {
        string[] ArrayObject =
        {
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
        };
        return new HashSet<string>(ArrayObject);
    }

    [Benchmark]
    public LinkedList<string> ReturnEmptyLinkedList()
    {
        string[] ArrayObject =
        {
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
        };
        return new LinkedList<string>(ArrayObject);
    }

    [Benchmark]
    public ICollection<string> ReturnEmptySortedSet()
    {
        string[] ArrayObject =
        {
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
        };
        return new SortedSet<string>(ArrayObject);
    }

    [Benchmark]
    public StringValues ReturnStringValues()
    {
        string[] ArrayObject =
        {
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
            "Three awdawd0115  awde",
            "Four 3435(awd ",
            "Five awdawd541",
            "Six 4151351",
            "Oneawwdf vsdv;p[	",
            "Two aaa-++=-`",
        };
        return new StringValues(ArrayObject);
    }
}