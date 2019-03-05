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
        private void Awake()
        {
            GetComponent<Button>()
                .OnClickAsObservable()
                .Subscribe(_ =>
                {
                    Log.I(GetComponentInChildren<Text>().text);
                    UIMgr.GetPanel<UITrainModePanel>().DoTransition<UIGamePanel>(new FadeInOut(),
                    uiData: new UIGamePanelData
                    {
                        InitLevelName = GetComponentInChildren<Text>().text,
                        Mode = GameMode.ModeTrain

                    });
                });

        }

        protected override void OnBeforeDestroy()
        {
        }
    }
}