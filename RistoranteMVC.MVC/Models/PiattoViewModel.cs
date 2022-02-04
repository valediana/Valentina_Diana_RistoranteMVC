using RistoranteMVC.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace RistoranteMVC.MVC.Models
{
    public class PiattoViewModel
    {
        
        public int Id{ get; set; }
        [Required]
        public string Nome { get; set; }
        public string? Descrizione { get; set; }
        
        public decimal Prezzo { get; set; }
        public Tipologia Tipologia { get; set; }
        public int? MenuId { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
