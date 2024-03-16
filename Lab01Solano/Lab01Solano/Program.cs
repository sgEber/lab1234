// See https://aka.ms/new-console-template for more information
using Lab01Solano;

Console.WriteLine("Hello, World!");

Operacion persona = new Operacion();

persona.ValorA = 10;
persona.ValorB = 20;

int suma = persona.Sumar();
int resta = persona.Restar();

Console.WriteLine("El resultado de la suma es : ");
Console.WriteLine(suma);
Console.WriteLine("El resultado de la resta es : ");
Console.WriteLine(resta);








CajeroAutomatico p1 = new CajeroAutomatico();

p1.Balance = 4500;
p1.AccountNumber = 123456789;
p1.SecurityPIN = 1234;
p1.AccountHolder = "Juan Caballero";

Console.WriteLine("CAJERO AUTOMATICO");
Console.WriteLine("1. Mostrar saldo 2.Depositar 3.Retirar 4.Cambiar pin");
int opcion =0;

switch (opcion)
{
    case 1:
        Console.WriteLine(p1.CheckBalance());
    break;
    case 2:
        Console.WriteLine("Ingrese la cantidad a depositar: ");
        double deposito = Convert.ToDouble(ConsoleReadLine());
        double Nbalance = p1.DepositFunds(deposito);
        Console.WriteLine("EL nuevo saldo es: "+Nbalance);
    break;
    case 3:
        Console.WriteLine("Ingrese la cantidad a retirar: ");
        double retiro = Convert.ToDouble(ConsoleReadLine());
        double N2balance = p1.WithdrawCash(retiro);
        Console.WriteLine("EL nuevo saldo es: " + N2balance);
    break;
    case 4:
        Console.WriteLine("Ingrese el antiguo pin");
        int op = Convert.ToInt32(ConsoleReadLine());
        Console.WriteLine("Ingrese el nuevo pin");
        int np = Convert.ToInt32(ConsoleReadLine());
        int nnp =p1.ChangePIN(op,np);
        Console.WriteLine("Se cambio la contraseña correctamente");
     break;
}

bool ConsoleReadLine()
{
    throw new NotImplementedException();
}