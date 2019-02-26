// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace oneGame
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using UnityEngine.UI;
    using QFramework;  
    
    public class UIHomePanelData : QFramework.UIPanelData
    {
    }
    
    public partial class UIHomePanel : QFramework.UIPanel
    {
        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as UIHomePanelData ?? new UIHomePanelData();
            // please add init code here
        }

        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {
        }

        protected override void RegisterUIEvent()
        {
            BtnStartGame.onClick.AddListener(() =>
            {
                UIMgr.OpenPanel<UIGamePanel>(new UIGamePanelData() {
                    DeathCount = 0,
                    InitLevelName = "Level1"
                });

                CloseSelf();
            });
        }

        protected override void OnOpen(QFramework.IUIData uiData)
        {
        }
        
        protected override void OnShow()
        {
        }
        
        protected override void OnHide()
        {
        }
        
        protected override void OnClose()
        {
        }
    }
}
