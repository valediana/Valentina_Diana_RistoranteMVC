using RistoranteMVC.Core.Entities;
using RistoranteMVC.MVC.Models;

namespace RistoranteMVC.MVC.Helper
{
    public static class Mapping
    {
        public static MenuViewModel ToMenuViewModel(this Menu menu)
        {
            List<PiattoViewModel> piattiViewModel = new List<PiattoViewModel>();
            foreach (var item in menu.PiattiMenu)
            {
                piattiViewModel.Add(item?.ToPiattoViewModel());
            }

            return new MenuViewModel
            {
                Id = menu.Id,
                Nome = menu.Nome,
                Piatti = piattiViewModel,
            };
        }

        public static Menu ToMenu(this MenuViewModel menuViewModel)
        {
            List<Piatto> piatti = new List<Piatto>();
            foreach (var item in menuViewModel.Piatti)
            {
                piatti.Add(item?.ToPiatto());
            }

            return new Menu
            {
                Id = menuViewModel.Id,
                Nome = menuViewModel.Nome,
                PiattiMenu = piatti,
                
            };
        }
        public static PiattoViewModel ToPiattoViewModel(this Piatto piatto)
        {
            return new PiattoViewModel
            {
                Id = piatto.Id,
                Nome = piatto.Nome,
                Descrizione= piatto.Descrizione,
                Prezzo= piatto.Prezzo,
                Tipologia= piatto.Tipologia,
                 
            };
        }
        public static Piatto ToPiatto(this PiattoViewModel piattoViewModel)
        {
            return new Piatto
            {
                Id = piattoViewModel.Id,
                Nome= piattoViewModel.Nome,
                Descrizione=piattoViewModel.Descrizione,
                Prezzo= piattoViewModel.Prezzo,
                Tipologia=piattoViewModel.Tipologia
                
            };
        }

    }
}
