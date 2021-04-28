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
   public class ViewProductModel
    {
        public ObservableCollection<ProductModel> Products { get; set; }
        public ProductModel productModel { get; set; }

        public ViewProductModel()
        {
            using (var context = new DataBaseModel())
            {
                context.Products.Load();
                Products = new ObservableCollection<ProductModel>();
                foreach (var item in context.Products.Local)
                {
                    Products.Add(ProductModel.FromProductModel(item));
                }
            }
        }
    }
}
