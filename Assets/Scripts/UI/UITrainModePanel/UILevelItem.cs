/****************************************************************************
 * 2019.3 风漫云端的MacBook Pro
 ****************************************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;
using UniRx;

namespace oneGame
{
    public partial class UILevelItem : UIElement
    {
        private string mLevelName;

        private void Awake()
        {
            GetComponent<Button>()
                .OnClickAsObservable()
                .Subscribe(_ =>
                {
                    SendMsg(new AudioSoundMsg("click"));
                    Log.I(GetComponentInChildren<Text>().text);
                    UIMgr.GetPanel<UITrainModePanel>().DoTransition<UIGamePanel>(new FadeInOut(),
                    uiData: new UIGamePanelData
                    {
                        InitLevelName = mLevelName,
                        Mode = GameMode.ModeTrain
                    });
                });

        }

        public void Init(string levelName)
        {
            mLevelName = levelName;
            TxtLevelName.text = levelName;
        }

        protected override void OnBeforeDestroy()
        {
        }
    }
}