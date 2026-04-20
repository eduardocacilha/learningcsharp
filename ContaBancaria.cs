namespace primeirosscriptsc_;


public class ContaBancaria()
{
    public string titular;
    public double saldo;

    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque.");
        }
    }



}