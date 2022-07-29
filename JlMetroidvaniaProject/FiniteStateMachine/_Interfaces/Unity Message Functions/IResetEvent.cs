namespace JlMetroidvaniaProject.FSM
{
    public interface IResetEvent : IUnityMessageEvent
    {
        void OnReset();
    }
}