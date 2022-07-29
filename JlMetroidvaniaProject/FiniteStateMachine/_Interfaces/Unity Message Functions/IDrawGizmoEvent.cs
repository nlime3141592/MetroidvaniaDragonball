namespace JlMetroidvaniaProject.FSM
{
    public interface IDrawGizmosEvent : IUnityMessageEvent
    {
        void OnDrawGizmos();
    }
}