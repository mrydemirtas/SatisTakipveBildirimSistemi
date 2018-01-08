using SatisTakipveBildirimSistemi.interfaces;
using SatisTakipveBildirimSistemi.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatisTakipveBildirimSistemi.services
{
    public class MessageManager
    {
        List<IMessageProvider> _messageProvider;

        public MessageManager(List<IMessageProvider> messageProvider)
        {
            _messageProvider = messageProvider;
        }

        public void SendMessage(string message)
        {
            foreach (var provider in _messageProvider)
            {
                provider.SendMessage(message);
            }
        }
    }
}
