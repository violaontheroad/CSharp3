namespace ByteBank.Sistemas.Funcionario
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get;  set; }
        public Autenticavel(double salario, string cpf)
        {
        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}