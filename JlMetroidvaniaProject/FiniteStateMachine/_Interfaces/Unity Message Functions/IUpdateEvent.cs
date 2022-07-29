namespace JlMetroidvaniaProject.FSM
{
    public interface IUpdateEvent : IUnityMessageEvent
    {
        void OnUpdate();
    }
}