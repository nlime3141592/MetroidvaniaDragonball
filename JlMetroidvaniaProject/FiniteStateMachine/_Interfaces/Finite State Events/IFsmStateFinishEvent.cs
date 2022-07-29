namespace JlMetroidvaniaProject.FSM
{
    public interface IFsmStateFinishEvent : IFiniteStateEvent
    {
        void OnFinishState();
    }
}