using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UniRx;
using UniRx.Async;

namespace WebRequest.UniRx {
    public class UniRxWebRequest : MonoBehaviour {
        async void Start() {
            var req = UnityWebRequest.Get("https://unity.com/");
            await req.SendWebRequest().ToUniTask();
            Debug.Log(req.downloadHandler.text);
        }

        // 旧型式
        //void Start() {
        //    ObservableWWW
        //        .Get("https://unity.com/")
        //        .Subscribe(x => {
        //            Debug.Log(x);
        //        })
        //        .AddTo(this);
        //}
    }
}
