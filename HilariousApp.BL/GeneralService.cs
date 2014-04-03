using HilariousApp.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HilariousApp.BL
{
    public class GeneralService : IGeneralService
    {
        private MyContext context = new MyContext();

        public void SendMessage(string name, string email, string message)
        {
            //TODO : Send message to website owner
            var messagex = new Message()
            {
                Name = name,
                Email = email,
                Content = message,
                Date=DateTime.Now
            };

            context.Messages.Add(messagex);
            context.SaveChanges();
        }


        public List<Message> FindAllMessage()
        {
            return context.Messages.ToList();
        }
    }
}
