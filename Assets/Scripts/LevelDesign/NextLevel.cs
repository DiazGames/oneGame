using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
using UnityEngine.SceneManagement;

namespace oneGame
{
    [AddComponentMenu("one Game/关卡设计/下一关")]
    public class NextLevel : ButtonActivated
    {
        static List<string> mLevelNamesOrder = new List<string>
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
            "GameWin"
        };
        
        /// <summary>
        /// When the button is pressed we start the dialogue
        /// </summary>
        public override void TriggerButtonAction()
        {
            if (!CheckNumberOfUses())
            {
                return;
            }
            base.TriggerButtonAction();
            GoToNextLevel();
            ActivateZone();
        }

        /// <summary>
        /// Loads the next level
        /// </summary>
        public virtual void GoToNextLevel()
        {
            string curLevelName = SceneManager.GetActiveScene().name;
            int curLevelIndex = mLevelNamesOrder.IndexOf(curLevelName);
            curLevelIndex++;
            string nextLevelName = mLevelNamesOrder[curLevelIndex];

            if (LevelManager.Instance != null)
            {
                LevelManager.Instance.GotoLevel(nextLevelName);
            }
            else
            {
                LoadingSceneManager.LoadScene(nextLevelName);
            }
        }

    }
}