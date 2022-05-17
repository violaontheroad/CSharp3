using ByteBank;  

    {
        ContaCorrente conta = new ContaCorrente(8566, 9383948);
        
        ContaCorrente conta1 = new ContaCorrente(8545, 9344948);
        
        ContaCorrente conta2 = new ContaCorrente(8536, 9383948);

        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        ContaCorrente conta3 = new ContaCorrente(453, 94858432);

        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


        Console.ReadLine();

    }


