using UnityEngine;

namespace Infrastructure
{
    public class GameFactory : IGameFactory
    {
        private readonly IAssetProvider _assets;

        public GameFactory(IAssetProvider assets)
        {
            _assets = assets;
        }

        public GameObject CreateHero() => 
            _assets.InstantiateEntity(Constants.PlayerPath);

        public void CreateGud() => 
            _assets.InstantiateEntity(Constants.HudPath);
    }
}