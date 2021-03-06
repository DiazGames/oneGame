using UnityEngine;
using QFramework;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

namespace oneGame
{
    /// <summary>
    /// App 入口类
    /// </summary>
    public class AppLoader : MonoBehaviour
    {
        private void Awake()
        {
            ResMgr.Init();

            //UIMgr.SetResolution(1024, 768, 1.0f);
            UIMgr.SetResolution(Screen.width, Screen.height, 1.0f);
            DontDestroyOnLoad(UIManager.Instance);
        }

        // Use this for initialization
        private void Start()
        {
            UIMgr.OpenPanel<UIHomePanel>();
        }

    }

    public static class GameData
    {
        public static int DeathCountMin
        {
            get
            {
                return PlayerPrefs.GetInt("DEATH_COUNT_MIN", int.MaxValue);
            }
            set
            {
                PlayerPrefs.SetInt("DEATH_COUNT_MIN", value);
            }
        }

        public static bool FirstTimeEnterLevel1
        {
            get
            {
                return PlayerPrefs.GetInt("FIRST_TIME_ENTER_LEVEL_1", 1) == 1 ? true : false;
            }
            set
            {
                PlayerPrefs.SetInt("FIRST_TIME_ENTER_LEVEL_1", value ? 1 : 0);
            }
        }

        public static string CurLevelName
        {
            get
            {
                return PlayerPrefs.GetString("CUR_LEVEL_NAME", "Level1");
            }
            set
            {
                PlayerPrefs.SetString("CUR_LEVEL_NAME", value);
            }
        }

        public static string UnLockLevelName
        {
            get
            {
                return PlayerPrefs.GetString("UN_LOCK_LEVEL_NAME", "Level1");
            }
            set
            {
                PlayerPrefs.SetString("UN_LOCK_LEVEL_NAME", value);
            }
        }

        public static int CurDeathCount
        {
            get
            {
                return PlayerPrefs.GetInt("CUR_DEATH_COUNT", 0);
            }
            set
            {
                PlayerPrefs.SetInt("CUR_DEATH_COUNT", value);
            }
        }
    }

    public static class LevelConfig
    {
        private static List<string> mLevelNamesOrder = new List<string>
        {
            "Level1",
            "Level2",
            "Level3",
            "Level4",
            "Level5",
            "Level6",
            "Level7",
            "Level8",
            "Level9",
            "Level10",
            "Level11",
            "Level12",
            "Level13",
            "Level14",
            "Level15",
            //"LevelTest",
            "GameWin"
        };

        public static List<string> LevelNamesOrder
        {
            get
            {
                return mLevelNamesOrder;
            }
        }

        public static int CurLevelIndex(string curLevelName)
        {
            return mLevelNamesOrder.IndexOf(curLevelName);
        }

        public static string GetNextLevelName()
        {
            int curLevelIndex = CurLevelIndex(SceneManager.GetActiveScene().name);
            curLevelIndex++;

            string nextLevelName = mLevelNamesOrder[curLevelIndex];
            if (curLevelIndex == mLevelNamesOrder.Count - 1)
            {
                GameData.CurLevelName = mLevelNamesOrder[0];
            }
            else
            {
                GameData.CurLevelName = nextLevelName;
                if (curLevelIndex == mLevelNamesOrder.Count -1)
                {
                    GameData.UnLockLevelName = mLevelNamesOrder[mLevelNamesOrder.Count - 1];
                }
                GameData.UnLockLevelName = nextLevelName;
            }

            return nextLevelName;
        }
    }
}