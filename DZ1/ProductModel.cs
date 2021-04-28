using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public static ProductModel FromProductModel(Entity.Products context)
        {
            return new ProductModel
            {
                Id = context.Id,
                Name = context.Name
            };

        }
        public static Entity.Products FromProductModel(ProductModel context)
        {
            using (var database = new Entity.DataBaseModel())
            {
                var product = database.Products.FirstOrDefault(u => u.Id == context.Id);
                return product;
            }

        }
    }
}
