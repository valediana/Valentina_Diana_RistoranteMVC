using RistoranteMVC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        public Esito AddNuovoPiatto(Piatto newPiatto);
        public List<Piatto> GetPiattiByMenuId(int menuId);
        public Esito DeletePiatto(int idPiatto);
        public Esito EditPiatto(int idPiatto, string newNome, string newDescrizione, decimal newPrezzo);
        public List<Piatto> GetAllPiatti();

        public Esito AddMenu(Menu newMenu);
        public Utente GetAccount(string username);
    }
}
