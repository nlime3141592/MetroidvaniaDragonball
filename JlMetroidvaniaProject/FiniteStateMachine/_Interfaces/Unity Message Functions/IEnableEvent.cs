namespace JlMetroidvaniaProject.FSM
{
    public interface IEnableEvent : IUnityMessageEvent
    {
        void OnEnable();
    }
}