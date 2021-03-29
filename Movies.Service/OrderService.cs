using Movies.Repository.Interfaces;
using Movies.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Service
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
    }
}
