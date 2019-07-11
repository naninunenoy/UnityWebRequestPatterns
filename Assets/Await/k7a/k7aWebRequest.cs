using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace WebRequest.Await.k7a {
    public class k7aWebRequest : MonoBehaviour {
        // コンパイルエラー
        async void Start() {
            var req = UnityWebRequest.Get("https://unity.com/");
            await req.SendWebRequest();
            Debug.Log(req.downloadHandler.text);
        }
    }
}
