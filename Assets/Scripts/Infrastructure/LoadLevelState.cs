using CameraLogic;
using UnityEngine;

namespace Infrastructure
{
    public class LoadLevelState : IPayloadedState<string>
    {
        private readonly GameStateMachine _stateMachine;
        private readonly SceneLoader _sceneLoader;


        public LoadLevelState(GameStateMachine stateMachine, SceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
        }

        public void Enter(string sceneName) => 
            _sceneLoader.LoadScene(sceneName, OnLoaded);

        public void Exit()
        {
        }

        private void OnLoaded()
        {
            GameObject player = InstantiateEntity(Constants.PrefabPlayer);
            InstantiateEntity(Constants.PrefabHud);
            
            CameraFollow(player);
        }

        private void CameraFollow(GameObject player) => 
            Camera.main.GetComponent<CameraFollow>().Follow(player);
        
        private static GameObject InstantiateEntity(string path)
        {
            GameObject prefab = Resources.Load<GameObject>(path);
            return Object.Instantiate(prefab);
        }
    }
}