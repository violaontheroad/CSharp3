using ByteBank;

class Program   
{
    static void Main(string[] args)
    {
        Cliente gabriela = new Cliente();

        gabriela.nome = "Gabriela";
        gabriela.profissao = "Dev C#";
        gabriela.cpf = "439.459.409-34";

        ContaCorrente conta = new ContaCorrente();

        conta.titular = gabriela;
        conta.saldo = 500;
        conta.agencia = 464;
        conta.numero = 239584;

        Console.WriteLine(gabriela.nome);
        Console.WriteLine(conta.titular.nome);

    }
}


