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
    using MoreMountains.Tools;
    using MoreMountains.CorgiEngine;
    using QFramework;
    using UniRx.Triggers;
    using UniRx;

    public class UIGamePausePanelData : QFramework.UIPanelData
    {
    }
    
    public partial class UIGamePausePanel : QFramework.UIPanel
    {

        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as UIGamePausePanelData ?? new UIGamePausePanelData();
            // please add init code here

        }

        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {
            throw new System.NotImplementedException ();
        }

        protected override void RegisterUIEvent()
        {
            ButtonBackHome.transform.Find("Container/Background").GetComponent<MMTouchButton>()
                .ButtonPressedFirstTime
                .AddListener(() =>
                {
                    UIMgr.ClosePanel<UIGamePanel>();
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
