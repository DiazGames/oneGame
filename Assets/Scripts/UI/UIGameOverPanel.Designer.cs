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
    
    
    public partial class UIGameOverPanel
    {
        
        public const string NAME = "UIGameOverPanel";
        
        [SerializeField()]
        public Text TxtDeathCountCurrent;
        
        [SerializeField()]
        public Text TxtDeathCountMin;
        
        [SerializeField()]
        public Button BtnBackHome;
        
        private UIGameOverPanelData mPrivateData = null;
        
        public UIGameOverPanelData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new UIGameOverPanelData());
            }
            set
            {
                mUIData = value;
                mPrivateData = value;
            }
        }
        
        protected override void ClearUIComponents()
        {
            TxtDeathCountCurrent = null;
            TxtDeathCountMin = null;
            BtnBackHome = null;
            mData = null;
        }
    }
}
