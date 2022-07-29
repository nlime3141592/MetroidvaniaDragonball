namespace JlMetroidvaniaProject.FSM
{
    public interface ILateUpdateEvent : IUnityMessageEvent
    {
        void OnLateUpdate();
    }
}