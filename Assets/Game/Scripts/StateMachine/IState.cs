namespace Game.SM
{
    public interface IState
    {
        void OnEntry();
        void OnUpdate(float deltaTime);
        void OnExit();
    }
}
