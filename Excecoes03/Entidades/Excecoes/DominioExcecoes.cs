using System;


namespace Excecoes03.Entidades.Excecoes {
    internal class DominioExcecoes : ApplicationException {
                                     // Subclasse de ApplicationException
        public DominioExcecoes(string mensagem) : base(mensagem) {

        }
    }
}
