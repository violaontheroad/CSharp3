namespace ByteBank.Sistemas.Funcionarios.Autenticavel
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if(usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao Sistema BYTE BANK");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta");
                return false;
            }
        }
    }

}