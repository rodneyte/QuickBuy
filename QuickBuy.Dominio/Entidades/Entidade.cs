using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _messagemValidacao { get; set; }

        public List<string> MensagemValidacao
        {
            get { return _messagemValidacao ?? (_messagemValidacao = new List<string>()); }
        }

        public abstract void Validade();

        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
