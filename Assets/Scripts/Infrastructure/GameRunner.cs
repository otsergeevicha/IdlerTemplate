using Plugins.MonoCache;
using UnityEngine;

namespace Infrastructure
{
    public class GameRunner : MonoCache
    {
        [SerializeField] private GameBootstrapper _gameBootstrapper;

        private void Awake()
        {
            var bootstrapper = FindObjectOfType<GameBootstrapper>();

            if (bootstrapper != null)
                return;

            Instantiate(_gameBootstrapper);
        }
    }
}