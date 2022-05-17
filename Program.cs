using ByteBank; 
using ByteBank.Funcionarios;

    {
       GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

       Funcionario carlos = new Funcionario();
       carlos.Nome = "Carlos";
       carlos.CPF = "948.895.456-03";
       carlos.Salario = 3000;

       gerenciador.Registrar(carlos);

       Diretor roberta = new Diretor();
        roberta.Nome = "Roberta";
        roberta.CPF = "898.546.465-94";
        roberta.Salario = 8000;

        gerenciador.Registrar(roberta);
       
        Console.WriteLine(carlos.Nome);
        Console.WriteLine(carlos.GetBonificacao());
      

        Console.WriteLine(roberta.Nome);
        Console.WriteLine(roberta.GetBonificacao());

        Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());

        Console.ReadLine();

    }

    


