using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Core.Entities
{
    public class Piatto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public Tipologia Tipologia { get; set; }
        public int? MenuId { get; set; }     //FK opzionale
        public Menu Menu { get; set; }
    }
    public enum Tipologia
    {
        Primo=0,
        Secondo=1,
        Contorno=2,
        Dolce=3
    }
}
