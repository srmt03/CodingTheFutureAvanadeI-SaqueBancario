using System;

class Program
{
    static void Main(string[] args)
    {
        // Obtendo o Saldo Total da Conta do Cliente
        //Console.Write("Digite o saldo total da sua conta bancária: ");
        int saldoTotal = int.Parse(Console.ReadLine());
        
        // Obtendo o Valor do Saque
        //Console.Write("Digite o valor que deseja sacar da sua conta bancária: ");
        int valorSaque = int.Parse(Console.ReadLine());
        
        // Verifica se o saldo da conta é o suficiente para realizar o Saque
        if (saldoTotal >= valorSaque) 
        {
          // Subtrair o valor do saque do saldo total
          saldoTotal -= valorSaque;
          Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {saldoTotal}");
          //Console.WriteLine("Saldo restante: " + saldoTotal);
        }
        else
        {
          // Exibir mensagem de Saldo Insuficiente
          Console.Write("Saldo insuficiente. Saque nao realizado!");
        }
    }
}
