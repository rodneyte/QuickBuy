using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _messagemValidacao { get; set; }

       private List<string> MensagemValidacao
        {
            get { return _messagemValidacao ?? (_messagemValidacao = new List<string>()); }
        }

        public abstract void Validade();

        protected void LimparMenssagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionaCritica(string menssagem)
        {
            MensagemValidacao.Add(menssagem);
        }
        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
