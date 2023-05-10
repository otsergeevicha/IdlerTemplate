using UnityEngine;

namespace Infrastructure
{
    public interface IAssetProvider
    {
        GameObject InstantiateEntity(string path);
    }
}