using RistoranteMVC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.Core.InterfaceRepositories
{
    public interface IRepositoryUtenti:IRepository<Utente>
    {
        public Utente GetById(int id);
        public Utente GetByUsername(string username);
    }
}
