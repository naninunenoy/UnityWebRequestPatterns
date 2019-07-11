using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.WebRequest;

namespace WebRequest.UniRx.Marimoiro {
    public class MarimoiroWebRequest : MonoBehaviour {
        void Start() {
            ObservableWebRequest
                .Get("https://unity.com/")
                .Subscribe(x => {
                    Debug.Log(x);
                })
                .AddTo(this);
        }
    }
}
