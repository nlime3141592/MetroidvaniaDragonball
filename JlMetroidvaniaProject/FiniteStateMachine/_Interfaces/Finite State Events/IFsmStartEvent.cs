namespace JlMetroidvaniaProject.FSM
{
    public interface IFsmStartEvent : IFiniteStateEvent
    {
        void OnStateMachineStart();
    }
}