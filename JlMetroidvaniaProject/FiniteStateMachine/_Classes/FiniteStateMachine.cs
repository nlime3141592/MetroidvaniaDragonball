using System;

namespace JlMetroidvaniaProject.FSM
{
    public abstract class FiniteStateMachine<T_Instance, T_StateEnum>
    where T_Instance : class
    where T_StateEnum : System.Enum
    {
        public T_Instance instance => m_instance;
        public T_StateEnum currentState => m_currentState;

        private T_Instance m_instance;
        private T_StateEnum m_currentState;
        private int m_currentStateIndex;
        private int m_stateCount;
        private FiniteState<T_Instance, T_StateEnum>[] m_states;

        public FiniteStateMachine(T_Instance fsmInstance, T_StateEnum initialState)
        {
            m_instance = fsmInstance;

            int enumCount = Enum.GetValues(typeof(T_StateEnum)).Length;
            m_stateCount = enumCount;

            m_states = new FiniteState<T_Instance, T_StateEnum>[enumCount];

            InitializeStates();
            m_StartMachine(initialState);
        }

        public void ChangeState(T_StateEnum nextState)
        {
            m_currentState.OnStateFinish();
            m_currentState = nextState;
            m_currentStateIndex = nextState.ToInt32();
            m_currentState.OnStateEnter();
        }

        protected abstract void InitializeStates();

        protected void SetStateInstance(FiniteState<T_Instance, T_StateEnum> stateInstance)
        {
            m_states[stateInstance.type.ToInt32()] = stateInstance;
        }

        private void m_StartMachine(T_StateEnum initialState)
        {
            m_currentState = initialState;
            m_currentStateIndex = initialState.ToInt32();
            OnMachineStart();
        }

        protected virtual void OnMachineStart() {}
        protected virtual void OnStateEnter() {}
        protected virtual void OnStateFinish() {}

        protected bool IsCurrentStateExists()
        {
            return m_states[m_currentStateIndex] != null;
        }
    }
}