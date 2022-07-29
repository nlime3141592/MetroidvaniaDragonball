namespace JlMetroidvaniaProject.FSM
{
    public interface IStartEvent : IUnityMessageEvent
    {
        void OnStart();
    }
}