using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristManagement
{
    public class User : IObserver
    {
        private string username;
        private ListBox notificationListBox;

        public User(string username, ListBox notificationListBox)
        {
            this.username = username;
            this.notificationListBox = notificationListBox;
        }

        public void Update(string message)
        {
            notificationListBox.Items.Add(message);
        }
    }
}
