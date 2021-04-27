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


        public static OrdersModel FromOrdersModel(Entity.Orders context)
        {
            //return new OrdersModel
            //{
            //    Id = context.Id,
            //    OrderName = context.OrderName
            //};
            var orderVM = new OrdersModel();
            orderVM.Id = context.Id;
            orderVM.OrderName = context.OrderName;
            return orderVM;
            
              
        
 }
    }
}
