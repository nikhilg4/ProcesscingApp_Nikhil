using ProcessingApp_Nikhil.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingApp_Nikhil
{
    public abstract class RulesHandler
    {
        protected RulesHandler successor;

        public void SetSuccessor(RulesHandler successor)
        {
            this.successor = successor;
        }
        public abstract void HandleRule(InputRequest inputRequest);
    }
}
