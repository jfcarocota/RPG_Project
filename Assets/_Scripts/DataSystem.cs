using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace GameUtils
{
    namespace DataSystem
    {
        public static class DataSystem
        {
            public static void SaveData(GameData gd)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Create(Application.persistentDataPath + "/rpggame.data");
                bf.Serialize(file, gd);
                file.Close();
            }

            public static void NewGame()
            {

            }

            public static GameData LoadGame()
            {
                if (FileExist)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream file = File.Open(Application.persistentDataPath + "/rpggame.data", FileMode.Open);
                    GameData gd = (GameData)bf.Deserialize(file);
                    file.Close();
                    return gd;
                }
                return null;
            }

            public static void PopulateDataBlocks()
            {
                
            }

            public static bool FileExist
            {
                get { return File.Exists(Application.persistentDataPath + "/rpggame.data"); }
            }
        }
    }
}
