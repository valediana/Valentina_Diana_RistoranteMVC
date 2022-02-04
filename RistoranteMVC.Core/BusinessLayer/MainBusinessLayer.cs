using RistoranteMVC.Core.Entities;
using RistoranteMVC.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IRepositoryPiatti PiattiRepo;
        private readonly IRepositoryMenu menuRepo;
        private readonly IRepositoryUtenti utentiRepo;


        public MainBusinessLayer(IRepositoryPiatti piatti, IRepositoryMenu menu, IRepositoryUtenti utenti)
        {
            PiattiRepo=piatti;
            menuRepo=menu;
            utentiRepo = utenti;
        }
        public Esito AddMenu(Menu newMenu)
        {
            throw new NotImplementedException();
        }

        public Esito AddNuovoPiatto(Piatto newPiatto)
        {
            throw new NotImplementedException();
        }

        public Esito DeletePiatto(int idPiatto)
        {
            throw new NotImplementedException();
        }

        public Esito EditPiatto(int idPiatto, string newNome, string newDescrizione, decimal newPrezzo)
        {
            throw new NotImplementedException();
        }

        public Utente GetAccount(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return null;
            }
            return utentiRepo.GetByUsername(username);
        }

        public List<Piatto> GetAllPiatti()
        {
            return PiattiRepo.GetAll();
        }

        public List<Piatto> GetPiattiByMenuId(int menuId)
        {
            throw new NotImplementedException();
        }
    }
}
