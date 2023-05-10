using Services.Inputs;

namespace Infrastructure
{
    public class Game
    {
        public static IInputService InputService;
        public GameStateMachine StateMachine;

        public Game(LoadingCurtain loadingCurtain)
        {
            StateMachine = new GameStateMachine(new SceneLoader(), loadingCurtain);
        }
    }
}