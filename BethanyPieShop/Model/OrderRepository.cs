using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Model
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly AppDbContext _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, AppDbContext shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _appDbContext.Orders.Add(order);
            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            order.OrderDetails = new List<OrderDetail>();

            // Czasem nie wszystkie obiekty kl. Pie w 'shoppingCartItems'
            // mają przypisaną jakąś wartość.
            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.Pie.PieId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Pie.Price
                };
                order.OrderDetails.Add(orderDetail);

            };
            _appDbContext.Orders.Add(order);

            _appDbContext.SaveChanges();
        }
    }
}
