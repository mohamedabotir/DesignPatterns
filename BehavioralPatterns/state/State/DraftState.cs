using state.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state.State
{
    internal class DraftState : IOrder
    {
        public OrderDecorator _order { get; set; }
        public DraftState(OrderDecorator order)
        {
            _order = order;
        }

        public void CancelState()
        {
            throw new NotImplementedException();
        }

        public void ConfirmationState()
        {
            _order._order = new ConfirmationState(_order);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Successfull Transition");
        }

        void IOrder.DraftState()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Successfull Transition");
        }
    }
}
