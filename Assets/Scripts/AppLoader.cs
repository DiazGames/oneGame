using UnityEngine;
using QFramework;

namespace oneGame
{
    /// <summary>
    /// App 入口类
    /// </summary>
    public class AppLoader : MonoBehaviour
    {
        private void Awake()
        {
            ResMgr.Init();
            UIMgr.SetResolution(1024, 768, 1.0f);
            DontDestroyOnLoad(UIManager.Instance);
        }

        // Use this for initialization
        void Start()
        {
            UIMgr.OpenPanel<UIHomePanel>();
        }

    }
}