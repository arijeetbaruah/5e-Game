namespace Game.SM
{
    public class StateMachine
    {
        public IState currentState = null;

        public virtual void SetState(IState nextState)
        {
            if (currentState != null)
            {
                currentState.OnExit();
            }

            currentState = nextState;

            currentState.OnEntry();
        }

        public virtual void OnUpdate(float deltaTime)
        {
            currentState?.OnUpdate(deltaTime);
        }
    }
}
