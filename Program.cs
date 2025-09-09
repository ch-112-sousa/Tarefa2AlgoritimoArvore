
using System.Text;
using Tarefa2AlgoritimoArvore;

public class Program
{
    public static void Main(string[] args)
    {

        var sb = new StringBuilder();

        string cenario1 = TreeAlg.GetStringCenarios(sb, new int[] { 3, 2, 1, 6, 0, 5 });
        Console.WriteLine($"CENARIO 1: {cenario1}");

        sb.Clear();

        string cenario2 = TreeAlg.GetStringCenarios(sb, new int[] { 7, 5, 13, 9, 1, 6, 4 });
        Console.WriteLine($"CENARIO 2: {cenario2}");

        Console.ReadLine();
    }
}