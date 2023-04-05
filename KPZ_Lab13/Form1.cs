using KPZ_Lab13.Patern;

namespace KPZ_Lab13
{
    public partial class Form1 : Form
    {

        private IChatRoom _chatRoom = new ChatRoom();
        private IParticipant _participant1;
        private IParticipant _participant2;
        private IParticipant _participant3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _participant1 = new Participant("Ben", listBox1);
            _participant2 = new Participant("Joe", listBox2);
            _participant3 = new Participant("Oleh", listBox3);

            _chatRoom.AddParticipant(_participant1);
            _chatRoom.AddParticipant(_participant2);
            _chatRoom.AddParticipant(_participant3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox2.Text;
            _chatRoom.SendMessage(message, _participant1);
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = textBox4.Text;
            _chatRoom.SendMessage(message, _participant2);
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = textBox6.Text;
            _chatRoom.SendMessage(message, _participant3);
            textBox6.Clear();
        }
    }
}