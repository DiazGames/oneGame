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
    using UnityEngine;
    using QFramework;
    using UniRx;

    public class UIHomePanelData : QFramework.UIPanelData
    {
    }
    
    public partial class UIHomePanel : QFramework.UIPanel
    {
        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as UIHomePanelData ?? new UIHomePanelData();
            // please add init code here

            TxtDeathCountMin.text = string.Format("Death Count Record : {0}", 
            GameData.DeathCountMin == int.MaxValue ? "None" : GameData.DeathCountMin.ToString());

            TxtVersion.text = "v" + Application.version;
        }

        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {
        }

        protected override void RegisterUIEvent()
        {
            BtnStartGame.OnClickAsObservable().Subscribe(_ =>
            {
                SendMsg(new AudioSoundMsg("click"));

                if (GameData.CurLevelName == "Level1")
                {
                    CloseSelf();
                    UIMgr.OpenPanel<UIStoryPanel>();
                }
                else
                {
                    this.DoTransition<UIGamePanel>(new FadeInOut(), uiData: new UIGamePanelData()
                    {
                        InitLevelName = GameData.CurLevelName
                    });
                }
            });

            BtnAbout.OnClickAsObservable().Subscribe(_ =>
            {
                SendMsg(new AudioSoundMsg("click"));
                UIMgr.OpenPanel<UIAboutPanel>(UILevel.PopUI);
            });

            BtnTrainMode.OnClickAsObservable().Subscribe(_ =>
            {
                CloseSelf();
                SendMsg(new AudioSoundMsg("click"));
                UIMgr.OpenPanel<UITrainModePanel>();
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
