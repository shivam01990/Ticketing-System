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
        private IGenericRepository<StateModel> repository = null;

        public List<StateModel> GetAllState()
        {
            using (TMSContext db = new TMSContext())
            {
                return db.State.ToList();
            }
        }
    }
}
