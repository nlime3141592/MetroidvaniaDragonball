namespace JlMetroidvaniaProject.FSM
{
    public interface ICollisionExitEvent<T_Collision> : IUnityMessageEvent
    {
        void OnCollisionExit(T_Collision collision);
    }
}