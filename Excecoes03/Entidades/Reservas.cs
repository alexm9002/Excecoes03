using System;
using Excecoes03.Entidades.Excecoes;

namespace Excecoes03.Entidades {
    class Reservas {
        public int NumeroQuarto { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }

        public Reservas(int numeroQuarto, DateTime entrada, DateTime saida) {
            if (saida <= entrada) {
                throw new DominioExcecoes("Data de Check-out não pode ser anterior a Data de Check-in ");
            }
            this.NumeroQuarto = numeroQuarto;
            this.Entrada = entrada;
            this.Saida = saida;
        }
        public int Duracao() { //MÉTODO
            // TimeSpan é usado para calcular duração de um período
            TimeSpan duracao = this.Saida.Subtract(this.Entrada);

            // Para transformar em dias usa-se a função "Total.Days"
            // transformando os dados em inteiro, pois o retorno do
            // "TotalDays" é feito em formato "Double".
            return (int)duracao.TotalDays;
        }
        public void AtualizarData(DateTime entrada, DateTime saida) {
            DateTime hoje = DateTime.Now;
            // Console.WriteLine(hoje.ToString());
            if (entrada < hoje || saida < hoje) {
                throw new DominioExcecoes("A data lançada para reserva precisa ser futura");
                //Não usa o "return", usa-se a cláusula "throw" para retornar a mensagem
            }
            if (saida <= entrada) {
                throw new DominioExcecoes("Data de Check-out não pode ser anterior a Data de Check-in ");
            }
            this.Entrada = entrada;
            this.Saida = saida;
        }

        public override string ToString() {
            return "Quarto: "
            + NumeroQuarto
            + ", Check-in: "
            + Entrada.ToString("dd/MM/yyyy")
            + ", Check-out: "
            + Saida.ToString("dd/MM/yyyy")
            + ", "
            + Duracao() //Colocar a função e não a variável.
            + " Noites.";
        }
    }
}
