using ByteBank; 
using ByteBank.Funcionarios;
class Program
{
    static void Main(string[] args)
    {       
        CalcularBonificacao();
        Console.ReadLine();
    }

    public static void CalcularBonificacao()
    {
        GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

        Funcionario pedro = new Designer("987.647.867-01");
        pedro.Nome = "Pedro";

        Funcionario roberta = new Diretor("387.647.867-01");
        roberta.Nome = "Roberta";

        Funcionario joao = new Gerente("187.647.867-01");
        joao.Nome = "Joao";
        joao.Senha = "abc";

        SistemaInterno.Logar(pedro, "839.9494.857-01");
        SistemaInterno.Logar(roberta, "123");
        SistemaInterno.Logar(joao, "abd");
    }
}


