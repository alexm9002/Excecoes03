using System;
using System.Collections.Generic;
using System.Globalization;
using Excecoes03.Entidades;
using Excecoes03.Entidades.Excecoes;


namespace Excecoes03 {
    class Program {
        static void Main(string[] args) {
            try {
                Console.Write("Número do Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                Console.Write("Data do Check-in (dd/MM/yyyy): ");
                DateTime entrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Data do Check-out (dd/MM/yyyy):");
                DateTime saida = DateTime.Parse(Console.ReadLine());
                Reservas reservas = new Reservas(numeroQuarto, entrada, saida);
                Console.WriteLine("Reserva --> " + reservas);
                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva!");
                Console.Write("Data do Check-in (dd/MM/yyyy): ");
                entrada = DateTime.Parse(Console.ReadLine());
                Console.Write("Data do Check-out (dd/MM/yyyy):");
                saida = DateTime.Parse(Console.ReadLine());

                reservas.AtualizarData(entrada, saida);
                Console.WriteLine("Reservas: " + reservas);
            }
            catch (DominioExcecoes e) {
                Console.WriteLine("Erro na reserva! " + e.Message);
            }
            catch (FormatException e) {
                Console.WriteLine("Formato digitado inválido! " + e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Erro Inesperado! " + e.Message);
            }
        }
    }
}