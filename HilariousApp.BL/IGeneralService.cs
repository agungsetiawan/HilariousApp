using HilariousApp.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HilariousApp.BL
{
    public interface IGeneralService
    {
        void SendMessage(string name,string email,string message);
        List<Message> FindAllMessage();
    }
}
