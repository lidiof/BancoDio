using System;
using System.Collections.Generic;

namespace BancoDio
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcU = OpcUsuario();
            while (opcU != "X")
            {
                switch(opcU){
                    case "1":
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcU = OpcUsuario();
            }
        }

        private static void InserirConta()
        {
            throw new NotImplementedException();
        }

        private static string OpcUsuario()
        {
            Console.WriteLine("Digite uma opção: \n" +
                "1- Listar Contas\n" +
                "2- Inserir nova conta\n" +
                "3- Transferir\n" +
                "4- Sacar\n" +
                "5- Depositar\n" +
                "C- Limpar Tela\n" +
                "X- Sair\n");
            string OpcUsuario = Console.ReadLine().ToUpper();

            return OpcUsuario;
        }
    }
    
}
