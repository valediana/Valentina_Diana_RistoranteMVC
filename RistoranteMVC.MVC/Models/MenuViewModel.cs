using System.ComponentModel.DataAnnotations;

namespace RistoranteMVC.MVC.Models
{
    public class MenuViewModel
    {
        
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
       

        public List<PiattoViewModel> Piatti { get; set; } = new List<PiattoViewModel>();
    }
}
