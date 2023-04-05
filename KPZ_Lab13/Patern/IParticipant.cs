
namespace KPZ_Lab13.Patern
{

    public interface IParticipant
    {
        string Name { get; }
        void ReceiveMessage(string message, string author);
    }
}
