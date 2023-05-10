using Plugins.MonoCache;
using UnityEngine;

namespace Infrastructure
{
    public class GameBootstrapper : MonoCache
    {
        [SerializeField] private LoadingCurtain _curtain;
        
        private Game _game;

        private void Awake()
        {
            _game = new Game(_curtain);
            _game.StateMachine.Enter<BootstrapState>();
            
            DontDestroyOnLoad(this);
        }
    }
}