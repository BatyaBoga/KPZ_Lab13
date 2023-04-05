using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_Lab13.Patern
{
    public class ChatRoom : IChatRoom
    {
        private List<IParticipant> _participants = new List<IParticipant>();

        public void AddParticipant(IParticipant participant)
        {
            _participants.Add(participant);
        }

        public void RemoveParticipant(IParticipant participant)
        {
            _participants.Remove(participant);
        }

        public void SendMessage(string message, IParticipant sender)
        {
            foreach (IParticipant participant in _participants)
            {
                if (participant != sender)
                {
                    participant.ReceiveMessage(message, sender.Name);
                }
            }
        }
    }
}
