using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    public class OrdersModel
    {      
        public int Id { get; set; }     
        public string OrderName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }


        public static OrdersModel FromOrdersModel(Entity.Orders contextOrder)
        {
            var database = new Entity.DataBaseModel();
                return new OrdersModel
                {
                    Id = contextOrder.Id,
                    OrderName = contextOrder.OrderName,
                    FirstName = contextOrder.Client.FirstOrDefault(_client=>(_client.OrderId == contextOrder.Id)).UserOfClient.FirstName,
                    LastName = contextOrder.Client.FirstOrDefault(_client => (_client.OrderId == contextOrder.Id)).UserOfClient.LastName,
                    MiddleName = contextOrder.Client.FirstOrDefault(_client => (_client.OrderId == contextOrder.Id)).UserOfClient.MiddleName,
                    Price = contextOrder.ListOfProductsInOrder.Where (o => o.OrderId == contextOrder.Id).Select (o => o.Products).Sum(p => p.Price),
                    Amount = contextOrder.ListOfProductsInOrder.Where(o=>o.OrderId== contextOrder.Id).Select(o=>o.Products).Count()
                };
            //var orderVM = new OrdersModel();
            //orderVM.Id = context.Id;
            //orderVM.OrderName = context.OrderName;
            //return orderVM;
        }
        public static Entity.Orders FromOrdersModel(OrdersModel context)
        {
            using (var database = new Entity.DataBaseModel())
            {
                var sale = database.Orders.FirstOrDefault(u => u.Id == context.Id);
                return sale;
            }
                
        }



 
    }
}
