namespace JlMetroidvaniaProject.FSM
{
    public interface IApplicationPauseEvent : IUnityMessageEvent
    {
        void OnApplicationPause();
    }
}