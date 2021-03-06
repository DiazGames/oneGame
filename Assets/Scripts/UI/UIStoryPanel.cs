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
    using System.Linq;
    using UnityEngine;
    using DG.Tweening;
    using QFramework;
    using UniRx;

    public class UIStoryPanelData : QFramework.UIPanelData
    {
    }
    
    public partial class UIStoryPanel : QFramework.UIPanel
    {
        
        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {
            throw new System.NotImplementedException ();
        }
        
        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as UIStoryPanelData ?? new UIStoryPanelData();
            // please add init code here

            var text = TxtStoryContent.text;
            TxtStoryContent.text = string.Empty;
            TxtStoryContent.DOText(text, 10.0f)
                .OnComplete(() =>
                {
                    //OpenGamePanel();
                    this.DoTransition<UIGamePanel>(new FadeInOut(), uiData: new UIGamePanelData()
                    {
                        InitLevelName = GameData.CurLevelName
                    });
                });

            // 点击屏幕显示所有文字
            Observable.EveryUpdate()
                .Where(_ => 
                Input.GetMouseButtonUp(0) || 
                Input.GetKey(KeyCode.H) || 
                Input.GetKey(KeyCode.Return) || 
                Input.GetKey(KeyCode.Space))
                .Subscribe(_ =>
                {
                    TxtStoryContent.DOKill();
                    TxtStoryContent.text = text;
                    BtnSkip.Show();
                }).AddTo(this);
        }

        protected override void RegisterUIEvent()
        {
            BtnSkip.OnClickAsObservable().Subscribe(_ =>
            {
                SendMsg(new AudioSoundMsg("click"));
                TxtStoryContent.DOKill();

                this.DoTransition<UIGamePanel>(new FadeInOut(), uiData: new UIGamePanelData()
                {
                    InitLevelName = GameData.CurLevelName
                });
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

        private void OpenGamePanel()
        {
            //CloseSelf();
            //UIMgr.OpenPanel<UIGamePanel>(new UIGamePanelData()
            //{
            //    //DeathCount = 0,
            //    InitLevelName = "Level1"
            //});

            this.DoTransition<UIGamePanel>(new FadeInOut(), uiData: new UIGamePanelData()
            {
                InitLevelName = "Level1"
            });
        }
    }
}
