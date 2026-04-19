namespace primeirosscriptsc_;


public class Placa()
{
    public void Main()
    {
        string[] placas = { "ABC1234", "XYZ9876", "QIH5E09", "S3X0E69", "B1E4A33" };
        int acertos = 0;

            foreach (string p in placas)
            {
            Console.WriteLine("Digite seu Palpite de PlacaAbaixo:");
            string palpite = Console.ReadLine()!;
    
                if (placas.Contains(palpite)) //uso do contains para listas e dicionariosss muito bom
                {
                    Console.WriteLine("Parabéns Você Acertou!");
                    acertos++;
                }
                else
                {
                    Console.WriteLine($"Você errou com esse palpite: {palpite} tente novamente");
                }
            }
        Console.WriteLine($"O Jogo Acabou e você finalizou com o total de {acertos}");

        }
    }


