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

            public static void LoadGame()
            {

            }

            public static void PopulateDataBlocks()
            {

            }
        }
    }
}
