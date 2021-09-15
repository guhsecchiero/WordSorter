using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveData (GameManager gameManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/GameManager.Save";
        FileStream stream = new FileStream(path, FileMode.Create);

        LevelData data = new LevelData(gameManager);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static LevelData LoadLevel()
    {
        string path = Application.persistentDataPath + "/GameManager.Save";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            LevelData data = formatter.Deserialize(stream) as LevelData;
            stream.Close();

            return data;

        }else
        {
            Debug.LogError("Arquivo salvo não encontrado " + path);
            return null;
        }
    }
}
