using Services.SaveLoadLogic;
using UnityEngine;

namespace Infrastructure.SaveLoadLogic
{
    public class SaveLoad : ISave
    {
        private DataBase _dataBase;
        private string _data;

        public SaveLoad()
        {
            _dataBase = PlayerPrefs.HasKey(Constants.Key)
                ? JsonUtility.FromJson<DataBase>(PlayerPrefs.GetString(Constants.Key))
                : new DataBase();
        }

        public void Save()
        {
            PlayerPrefs.SetString(Constants.Key, ConvertJson(_dataBase));
            PlayerPrefs.Save();
        }

        private string ConvertJson<TData>(TData data) => 
            JsonUtility.ToJson(data);
    }
}