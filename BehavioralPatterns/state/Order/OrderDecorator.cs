using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using state.State;
using strategy;
namespace state.Orders
{
    public class OrderDecorator : strategy.Order
    {
        public IOrder _order { get; set; }
        public OrderDecorator()
        {
            _order = new DraftState(this);
        }

        public void CancelState()
        {
            _order.CancelState();
        }

        public void ConfirmationState()
        {
            _order.ConfirmationState();
        }

       public void  DraftState()
        {
            _order.DraftState();
        }
    }
}
