using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

namespace WebRequest.Await.k7a {
    public class UnityWebRequestAsyncOperationAwaiter : INotifyCompletion {
        UnityWebRequestAsyncOperation _asyncOperation;

        public bool IsCompleted {
            get { return _asyncOperation.isDone; }
        }

        public UnityWebRequestAsyncOperationAwaiter(UnityWebRequestAsyncOperation asyncOperation) {
            _asyncOperation = asyncOperation;
        }

        public void GetResult() {
            // NOTE: 結果はUnityWebRequestからアクセスできるので、ここで返す必要性は無い
        }

        public void OnCompleted(Action continuation) {
            _asyncOperation.completed += _ => { continuation(); };
        }
    }
}
