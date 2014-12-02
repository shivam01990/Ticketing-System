using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelEntity;

namespace DataLayer
{
    public class StateProvider
    {
        TMSContext db = new TMSContext();


        public List<StateModel> GetAllState()
        {
            using (TMSContext db = new TMSContext())
            {
                   GenericRepository<StateModel> repository = new GenericRepository<StateModel>(db);
                // return db.State.ToList();
                return repository.SelectAll().ToList();
            }
        }
    }
}
