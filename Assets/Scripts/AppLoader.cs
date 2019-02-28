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
            UIMgr.SetResolution(1024, 768, 1.0f);
            DontDestroyOnLoad(UIManager.Instance);
        }

        // Use this for initialization
        private void Start()
        {
            UIMgr.OpenPanel<UIHomePanel>();
        }

    }

    public class GameData
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
    }

    public class LevelConfig
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

        public static string GetNextLevelName()
        {
            string curLevelName = SceneManager.GetActiveScene().name;
            int curLevelIndex = mLevelNamesOrder.IndexOf(curLevelName);
            curLevelIndex++;
           
            return mLevelNamesOrder[curLevelIndex];
        }
    }
}