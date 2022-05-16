
ContaCorrente contaDoBruno = new ContaCorrente();

contaDoBruno.titular = "Bruno";
bool resultadoSaque = contaDoBruno.Sacar(50);

Console.WriteLine(resultadoSaque);
Console.WriteLine(contaDoBruno.saldo); 

contaDoBruno.Depositar(500);
Console.WriteLine(contaDoBruno.saldo); 

// implementando a função Transferir

ContaCorrente contaDoViola = new ContaCorrente();

contaDoViola.titular = "Viola";

contaDoBruno.Transferir(300, contaDoViola);

Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
Console.WriteLine("Saldo do Viola: " + contaDoViola.saldo);

Console.ReadLine();




