using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


namespace WebRequest {
    public class CoroutineWebRequest : MonoBehaviour {
        IEnumerator Start() {
            var req = UnityWebRequest.Get("https://unity.com/");
            yield return req.SendWebRequest();
            Debug.Log(req.downloadHandler.text);
        }
    }
}
