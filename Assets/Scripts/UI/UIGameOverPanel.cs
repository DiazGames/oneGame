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
    
    public class UIGameOverPanelData : QFramework.UIPanelData
    {
        public int DeathCountCurrent = 10;
    }
    
    public partial class UIGameOverPanel : QFramework.UIPanel
    {
        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as UIGameOverPanelData ?? new UIGameOverPanelData();
            // please add init code here

            GameData.DeathCountMin = GameData.DeathCountMin >= mData.DeathCountCurrent ? mData.DeathCountCurrent : GameData.DeathCountMin;

            TxtDeathCountCurrent.text = string.Format("Death Count : {0}", mData.DeathCountCurrent);
            TxtDeathCountMin.text = string.Format("Death Count Record : {0}", GameData.DeathCountMin);

        }

        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {
        }

        protected override void RegisterUIEvent()
        {
            BtnBackHome.onClick.AddListener(() =>
            {
                SendMsg(new AudioSoundMsg("click"));
                CloseSelf();
                UIMgr.OpenPanel<UIHomePanel>();
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
