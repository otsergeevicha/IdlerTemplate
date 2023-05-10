using UnityEngine;

namespace Infrastructure
{
    public interface IGameFactory
    {
        GameObject CreateHero();
        void CreateGud();
    }
}