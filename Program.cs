using System;

namespace _24_11_Correcao___fixacao__fucoes
{
    class Program
    {
        static void Main(string[] args)
        {
          
           
            Console.WriteLine("Digite o ano atual");
            int anoAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano do seu nascimento");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idadeRetornada = CalculaIdade(anoAtual, anoNascimento);

            Console.WriteLine($"A idade é de {idadeRetornada}");

           int CalculaIdade(int atual, int nascimento){
            
                int idade = atual - nascimento;   
            
               return idade;
            }


        }
    }
}
