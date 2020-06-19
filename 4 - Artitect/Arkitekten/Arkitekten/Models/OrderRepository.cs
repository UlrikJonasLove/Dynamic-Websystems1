using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arkitekten.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart )
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
            var order_id = order.OrderId;
            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            foreach (var shoppingCartitem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartitem.Amount,
                    ProductId = shoppingCartitem.Product.ProductId,
                    OrderId = order_id,
                    Price = shoppingCartitem.Product.Price
                };
                _appDbContext.OrderDetails.Add(orderDetail);
                _appDbContext.SaveChanges();
            }
        }
    }
}
