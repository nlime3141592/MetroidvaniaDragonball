namespace JlMetroidvaniaProject.FSM
{
    public interface ITriggerEnterEvent<T_Collider> : IUnityMessageEvent
    {
        void OnTriggerEnter(T_Collider collider);
    }
}