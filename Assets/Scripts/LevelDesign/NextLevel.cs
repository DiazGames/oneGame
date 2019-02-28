using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

namespace oneGame
{
    [AddComponentMenu("one Game/关卡设计/下一关")]
    public class NextLevel : ButtonActivated
    {
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

    }
}