using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace WebRequest.Await {
    public class AwaitWebRequest : MonoBehaviour {
        async void Start() {
            Debug.Log(await GetContentAsync("https://unity.com/"));
        }

        async Task<string> GetContentAsync(string url) {
            var req = UnityWebRequest.Get(url);
            var tcs = new TaskCompletionSource<string>();
            req.SendWebRequest().completed += _ => { tcs.SetResult(req.downloadHandler.text); };
            return await tcs.Task;
        }

        // コンパイルエラー
        //async void Start() {
        //    var req = UnityWebRequest.Get("https://unity.com/");
        //    await req.SendWebRequest();
        //    Debug.Log(req.downloadHandler.text);
        //}
    }
}
