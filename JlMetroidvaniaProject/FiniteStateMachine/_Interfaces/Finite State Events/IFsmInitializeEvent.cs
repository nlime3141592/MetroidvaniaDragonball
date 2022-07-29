namespace JlMetroidvaniaProject.FSM
{
    public interface IFsmInitializeEvent : IFiniteStateEvent
    {
        void OnStateInitialize();
    }
}