namespace ByteBank.Funcionarios.Autenticavel
{
    public class Gerente : Autenticavel
    {
        public Gerente(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando Gerente");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonificacao()
        {   
            return Salario*0.7;
        }

    }


}
