using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state.State
{
    public interface IOrder
    {
        public void CancelState();
        public void ConfirmationState();
        public void DraftState();
    }
}
