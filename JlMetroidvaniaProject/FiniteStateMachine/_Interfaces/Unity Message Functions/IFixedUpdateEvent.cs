namespace JlMetroidvaniaProject.FSM
{
    public interface IFixedUpdateEvent : IUnityMessageEvent
    {
        void OnFixedUpdate();
    }
}