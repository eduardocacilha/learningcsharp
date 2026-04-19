namespace primeirosscriptsc_;

public class Moto() {

    public string modelo;
    public double consumoKmL;
    public int capacidadeTanque;


    public void CalcularCustoViagem(int distancia, double precoGasolina) {
        double litrosNecessarios = distancia / consumoKmL;
        double CustoViagem = litrosNecessarios * precoGasolina;   

        Console.WriteLine($"O custo da viagem é: R${CustoViagem:F2}"); 
        Console.WriteLine($"A quantidade de litros necessários para a viagem é: {litrosNecessarios:F2} litros");
    }
   
   







}