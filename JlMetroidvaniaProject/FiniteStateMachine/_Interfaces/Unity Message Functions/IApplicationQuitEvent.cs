namespace JlMetroidvaniaProject.FSM
{
    public interface IApplicationQuitEvent : IUnityMessageEvent
    {
        void OnApplicationQuit();
    }
}