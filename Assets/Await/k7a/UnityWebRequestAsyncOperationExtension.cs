using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace WebRequest.Await.k7a {
    public static class UnityWebRequestAsyncOperationExtension {
        public static UnityWebRequestAsyncOperationAwaiter GetAwaiter(this UnityWebRequestAsyncOperation asyncOperation) {
            return new UnityWebRequestAsyncOperationAwaiter(asyncOperation);
        }
    }
}
