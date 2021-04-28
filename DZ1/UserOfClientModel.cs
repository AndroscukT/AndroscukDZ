using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    public class UserOfClientModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }     
        public string MiddleName { get; set; }

        public static UserOfClientModel FromUserOfClientModel(Entity.UserOfClient context)
        {
            return new UserOfClientModel
            {
                Id = context.Id,
                LastName = context.LastName,
                FirstName = context.FirstName,
                MiddleName = context.MiddleName
            };

        }
        public static Entity.UserOfClient FromUserOfClientModel(UserOfClientModel context)
        {
            using (var database = new Entity.DataBaseModel())
            {
                var user = database.UserOfClient.FirstOrDefault(u => u.Id == context.Id);
                return user;
            }

        }
    }
}
