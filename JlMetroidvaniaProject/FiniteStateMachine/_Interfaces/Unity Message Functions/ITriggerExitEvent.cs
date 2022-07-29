namespace JlMetroidvaniaProject.FSM
{
    public interface ITriggerExitEvent<T_Collider> : IUnityMessageEvent
    {
        void OnTriggerExit(T_Collider collider);
    }
}