namespace JlMetroidvaniaProject.FSM
{
    public interface IGuiEvent : IUnityMessageEvent
    {
        void OnGUI();
    }
}