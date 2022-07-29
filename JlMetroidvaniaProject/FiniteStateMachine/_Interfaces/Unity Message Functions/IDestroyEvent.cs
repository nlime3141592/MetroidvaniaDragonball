namespace JlMetroidvaniaProject.FSM
{
    public interface IDestroyEvent : IUnityMessageEvent
    {
        void OnDestroy();
    }
}