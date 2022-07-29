namespace JlMetroidvaniaProject.FSM
{
    public interface IFsmStateStartEvent : IFiniteStateEvent
    {
        void OnStartState();
    }
}