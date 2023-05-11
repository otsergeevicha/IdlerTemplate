using CameraLogic;
using Infrastructure.Factory;
using UnityEngine;

namespace Infrastructure.States
{
    public class LoadLevelState : IPayloadedState<string>
    {
        private readonly GameStateMachine _stateMachine;
        private readonly SceneLoader _sceneLoader;
        private readonly LoadingCurtain _loadingCurtain;
        private readonly IGameFactory _gameFactory;
        
        public LoadLevelState(GameStateMachine stateMachine, SceneLoader sceneLoader, LoadingCurtain loadingCurtain, IGameFactory gameFactory)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
            _loadingCurtain = loadingCurtain;
            _gameFactory = gameFactory;
        }

        public void Enter(string sceneName)
        {
            _loadingCurtain.Show();
            _sceneLoader.LoadScene(sceneName, OnLoaded);
        }

        public void Exit() => 
            _loadingCurtain.Hide();

        private void OnLoaded()
        {
            GameObject player = _gameFactory.CreateHero();
            _gameFactory.CreateGud();
            
            CameraFollow(player);
            
            _stateMachine.Enter<GameLoopState>();
        }

        private void CameraFollow(GameObject player) => 
            Camera.main.GetComponent<CameraFollow>().Follow(player);
    }
}