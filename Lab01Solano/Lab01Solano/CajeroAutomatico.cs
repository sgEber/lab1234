using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Solano
{
    internal class CajeroAutomatico : CuentaBancaria
    {

        public double CheckBalance()
        {
            return Balance;
        }

        public double DepositFunds(double Deposit)
        {
            Balance += Deposit;
            return Balance;
        }

        public double WithdrawCash(double withdraw)
        {
            try
            {
                if (Balance < withdraw)
                {
                    throw new InvalidOperationException("Saldo insuficiente.");
                }
                Balance -= withdraw;
                return Balance;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
        }

        public int ChangePIN(int OldPIN, int NewPIN)
        {
            try
            {
                if (OldPIN != SecurityPIN)
                {
                    throw new ArgumentException("La contraseña antigua no es correcta.");
                }

                if (NewPIN == OldPIN)
                {
                    throw new ArgumentException("La nueva contraseña no puede ser igual a la contraseña antigua.");
                }
                SecurityPIN = NewPIN;
                return SecurityPIN;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return -1;
            }
        }
    }
}
