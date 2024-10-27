using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using ProjetoAnaliseAlgoritimo;

BenchmarkSwitcher
    .FromAssembly(typeof(Program).Assembly)
    .Run(args);


[ShortRunJob]
[MemoryDiagnoser]
public class Algoritimos
{

    private int[] ints;
    private int[] arrayQuickSort;
    private int[] arrayQuickSortWithInsertion;
    private int[] arrayQuickSortMedianOfThree;



    [Params(5, 10, 15, 20, 30, 50, 70, 100)] // Valores de M para testar
    public int M { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        var random = new Random();
        ints = new int[1000];

        for (int i = 0; i < ints.Length; i++)
        {
            ints[i] = random.Next(0, 10000);
        }

        arrayQuickSort = (int[])ints.Clone();
        arrayQuickSortWithInsertion = (int[])ints.Clone();
        arrayQuickSortMedianOfThree = (int[])ints.Clone();
    }

    [Benchmark]
    public void QuickSortBenchmark()
    {
        //int[] arrayCopy = (int[])ints.Clone();
        QuickSort.Sort(arrayQuickSort);
        Console.WriteLine($"QuickSort comparacoes: {QuickSort.Comparisons}, swaps: {QuickSort.Swaps}");
    }

    [Benchmark]
    public void QuickSortWithInsertionBenchmark()
    {
        //int[] arrayCopy = (int[])ints.Clone();
        QuickSortWithInsertionSort.Sort(arrayQuickSortWithInsertion, M);
        Console.WriteLine($"QuickSortWithInsertion comparacoes: {QuickSortWithInsertionSort.Comparisons}, swaps: {QuickSortWithInsertionSort.Swaps}");
    }

    [Benchmark]
    public void QuickSortMedianOfThreeBenchmark()
    {
        //int[] arrayCopy = (int[])ints.Clone();
        QuickSortMedianOfThree.Sort(arrayQuickSortMedianOfThree, M);
        Console.WriteLine($"QuickSortMedianOfThree comparacoes: {QuickSortMedianOfThree.Comparisons}, swaps: {QuickSortMedianOfThree.Swaps}");
    }
}
