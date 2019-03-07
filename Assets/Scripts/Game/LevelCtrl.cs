using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using UniRx;

namespace oneGame
{
    public class LevelCtrl : MonoBehaviour
    {

        private IEnumerator Start()
        {
            // 只显示火箭的能量条

            yield return new WaitForSeconds(0.5f);

            var carmeraObj = GameObject.Find("UICamera");

            Transform canvasTrans = null;

            yield return new WaitUntil(() => canvasTrans = carmeraObj.transform.Find("Canvas"));

            Transform hudTrans = null;

            yield return new WaitUntil(() => hudTrans = canvasTrans.Find("HUD"));

            hudTrans.Show();
            hudTrans.Find("JetpackBar").Show();
            hudTrans.Find("HealthBar").Hide();
            hudTrans.Find("AvatarBackground").Hide();
            hudTrans.Find("AvatarHead").Hide();

        }


    }
}