namespace JlMetroidvaniaProject.FSM
{
    public interface ICollisionEnterEvent<T_Collision> : IUnityMessageEvent
    {
        void OnCollisionEnter(T_Collision collision);
    }
}