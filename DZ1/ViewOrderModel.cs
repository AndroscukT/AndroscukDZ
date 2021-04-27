using DZ1.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    public class ViewOrderModel
    {
        public ObservableCollection<ViewOrderModel> Orders { get; set; }

        public ViewOrderModel()
        {
            using (var context = new DataBaseModel())
            {
                context.Orders.Load();
                Orders = new ObservableCollection<ViewOrderModel>( (from order in context.Orders.Local select ViewOrderModel.orderVM(order)).ToList());
            }
        }
    }
}
