using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using QFramework;
using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace oneGame
{
    /// <summary>
    /// 游戏模式
    /// </summary>
    public enum GameMode
    {
        // 普通模式
        ModeNormal,
        // 训练模式
        ModeTrain
    }

    public class GameModeLogic : MonoBehaviour
    {
        public static GameMode Mode = GameMode.ModeNormal;

        public static void LevelFinish()
        {
            if (Mode == GameMode.ModeNormal)
            {
                string nextLevelName = LevelConfig.GetNextLevelName();

                if (LevelManager.Instance != null)
                {
                    LevelManager.Instance.GotoLevel(nextLevelName);
                }
                else
                {
                    LoadingSceneManager.LoadScene(nextLevelName);
                }
            }
            else
            {
                SceneManager.LoadScene("Empty");

                UIMgr.ClosePanel<UIGamePanel>();

                UIMgr.OpenPanel<UITrainModePanel>();
            }
        }

    }
}