using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DH.CurbSide.Infrastructure;
using DH.CurbSide.Domain;

namespace DH.CurbSide.Repository
{
    public class WhitelistRepo
    {
        public IEnumerable<Whitelist> GetWhitelist(string searchEmail)
        {
            List<Whitelist> wlList = new List<Whitelist>();
            
            using (DataContext db = new DataContext())
            {
                // try
                // {
                if (!string.IsNullOrEmpty(searchEmail))
                {
                    var wlQuery = from wlist in db.Whitelists
                                  where wlist.EmailAddress.Contains(searchEmail)
                                  select wlist;
                    wlList = wlQuery.ToList();
                }
                else
                {
                    var wlQuery = from wlist in db.Whitelists
                                  select wlist;
                    wlList = wlQuery.ToList();
                }

                /*} catch(Exception ex)
                {
                    string err = ex.InnerException.ToString();
                }
                */
            }
            
            return wlList;
        }             
    }
}
