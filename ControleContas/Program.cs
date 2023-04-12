// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using ControleContas.Model;
try
{
    Cliente gustavo = new Cliente("Gustavo", "12321341234", 2002);
    Banco santander = new Banco("Santander", 1234);
    Agencia santanderBP = new Agencia("938262", 0123, santander);
    Conta contaGustavo= new Conta(123456789, santanderBP, gustavo,  1000);

    Cliente gabriel = new Cliente("Gabriel", "12312423452", 2001);
    Banco bradesco = new Banco("Bradesco", 1235);
    Agencia bradescoBP = new Agencia("7392034", 0362, bradesco);
    Conta contaGabriel = new Conta(937290027, bradescoBP, gabriel, 1001);

    Console.WriteLine($"{contaGustavo.ToString()}");
    Console.WriteLine($"{contaGabriel.ToString()}");

    Console.WriteLine("O saldo total das contas é " + (contaGustavo.Saldo + contaGabriel.Saldo));

    Console.WriteLine($"A conta de maior saldo é {Conta._contaMaiorSaldo} cujo saldo é {Conta._maiorSaldo}");

}
catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}