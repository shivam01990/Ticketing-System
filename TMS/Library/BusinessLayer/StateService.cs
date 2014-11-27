using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using ModelEntity;

namespace BusinessLayer
{
    public class StateService
    {
        StateProvider objstate = new StateProvider();
        public List<StateModel> GetAllState()
        {
            return objstate.GetAllState();
        }
    }
}
