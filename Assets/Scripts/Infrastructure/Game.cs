using Infrastructure.States;

namespace Infrastructure
{
    public class Game
    {
        public readonly GameStateMachine StateMachine;

        public Game(LoadingCurtain loadingCurtain) => 
            StateMachine = new GameStateMachine(new SceneLoader(), loadingCurtain);
    }
}