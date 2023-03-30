using state.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state.State
{
    internal class CancelState : IOrder
    {
        public OrderDecorator _order { get; set; }
        public CancelState(OrderDecorator order)
        {
            _order = order; 
        }
        public void ConfirmationState()
        {
            throw new NotImplementedException();
        }

        public void DraftState()
        {
            _order._order = new DraftState(_order);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Successfull Transition");
        }

        void IOrder.CancelState()
        {
            _order._order = new ConfirmationState(_order);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Successfull Transition");
        }
    }
}
