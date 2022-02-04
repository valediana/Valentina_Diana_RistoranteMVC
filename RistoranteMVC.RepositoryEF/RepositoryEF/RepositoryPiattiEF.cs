using RistoranteMVC.Core.Entities;
using RistoranteMVC.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RistoranteMVC.RepositoryEF.RepositoryEF
{
    public class RepositoryPiattiEF : IRepositoryPiatti
    {
        private readonly MasterContext ctx;

        public RepositoryPiattiEF(MasterContext context)
        {
            ctx = context;
        }
        public Piatto Add(Piatto item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Piatto item)
        {
            throw new NotImplementedException();
        }

        public List<Piatto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Piatto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Piatto Update(Piatto item)
        {
            throw new NotImplementedException();
        }
    }
}
