namespace primerirosscriptsc_;


public class ValidaSenha() {
    public string senha;

    public void ValidaTamanho()
    {
        if (senha.Length >= 8 && (senha.Contains("@") || senha.Contains("#") || senha.Contains("!")))
        {
            Console.WriteLine("A senha é válida.");
        }
        else
        {
            Console.WriteLine("A senha é inválida. Ela deve conter pelo menos 8 caracteres e pelo menos um desses caracteres: (@, #, !)");
        }
    }

 



 }