
using System.Transactions;

namespace primeirosscriptsc_;


public class MediaInputada
{
    public void RetonaMedia(double nota1, double nota2)
    {
        double media = (nota1 + nota2) / 2;

        Console.WriteLine($"sua media inputada ficou {media:F2}");

    }
}
