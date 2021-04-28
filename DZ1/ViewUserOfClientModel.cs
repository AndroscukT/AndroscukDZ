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
    public class ViewUserOfClientModel
    {
        public ObservableCollection<UserOfClientModel> UserOfClients { get; set; }
        public UserOfClientModel userOf { get; set; }

        public ViewUserOfClientModel ()
        {
            using (var context = new DataBaseModel())
            {
                context.UserOfClient.Load();
                UserOfClients = new ObservableCollection<UserOfClientModel>();
                foreach (var item in context.UserOfClient.Local)
                {
                    UserOfClients.Add(UserOfClientModel.FromUserOfClientModel(item));
                }
            }
        }
    }
}
