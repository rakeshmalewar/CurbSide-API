using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DH.CurbSide.Infrastructure;
using DH.CurbSide.Domain;

namespace DH.CurbSide.Repository
{
    public class ProviderRepo
    {
        public IEnumerable<Provider> GetProviders()
        {
            List<Provider> prvdList = new List<Provider>();
            using (DataContext db = new DataContext())
            {
                var prvdQuery = from prvd in db.ProvidersList
                                select prvd;
                prvdList = prvdQuery.ToList();
            }
            return prvdList;
        }
    }
}
