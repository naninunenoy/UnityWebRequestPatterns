using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace WebRequest.Basic {
    public class AsyncOperationWebRequest : MonoBehaviour {
        void Start() {
            var req = UnityWebRequest.Get("https://unity.com/");
            req.SendWebRequest().completed += _ => { Debug.Log(req.downloadHandler.text); };
        }
    }
}
