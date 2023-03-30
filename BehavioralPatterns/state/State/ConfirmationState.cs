using state.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state.State
{
    internal class ConfirmationState : IOrder
    {
        public OrderDecorator _order { get; set; }
        public ConfirmationState(OrderDecorator order)
        {
            _order = order;
        }
        public void CancelState()
        {
            throw new NotImplementedException();
        }

        public void DraftState()
        {
            throw new NotImplementedException();
        }

        void IOrder.ConfirmationState()
        {
            _order._order = new ConfirmationState(_order);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Successfull Transition");
        }
    }
}
