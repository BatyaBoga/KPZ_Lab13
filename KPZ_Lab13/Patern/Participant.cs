using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_Lab13.Patern
{
    public class Participant : IParticipant
    {
        public string Name { get; }
        private ListBox _chatBox;

        public Participant(string name, ListBox chatBox)
        {
            Name = name;
            _chatBox = chatBox;
        }

        public void ReceiveMessage(string message, string author)
        {
            _chatBox.Invoke(new Action(() => _chatBox.Items.Add($"{author}: {message}")));
        }
    }

}
