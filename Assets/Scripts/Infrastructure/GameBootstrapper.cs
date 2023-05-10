using Plugins.MonoCache;

namespace Infrastructure
{
    public class GameBootstrapper : MonoCache
    {
        private Game _game;

        private void Awake()
        {
            _game = new Game();
            _game.StateMachine.Enter<BootstrapState>();
            
            DontDestroyOnLoad(this);
        }
    }
}