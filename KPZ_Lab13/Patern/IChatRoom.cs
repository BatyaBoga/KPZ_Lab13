namespace KPZ_Lab13.Patern
{
    public interface IChatRoom
    {
        void AddParticipant(IParticipant participant);
        void RemoveParticipant(IParticipant participant);
        void SendMessage(string message, IParticipant sender);
    }
}
