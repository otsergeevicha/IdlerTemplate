using Services.Inputs;

namespace Infrastructure
{
    public class Game
    {
        public static IInputService InputService;
        public GameStateMachine StateMachine;

        public Game()
        {
            StateMachine = new GameStateMachine(new SceneLoader());
        }
    }
}