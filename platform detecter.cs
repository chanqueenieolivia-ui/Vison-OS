using UnityEngine;

public class PlatformDetector : MonoBehaviour {
    public string DetectPlatform() {
        #if UNITY_WEBGL
            Debug.Log("平台：Chrome WebGL");
            return "Chrome";
        #elif UNITY_STANDALONE
            Debug.Log("平台：Unity 桌面版");
            return "Unity";
        #else
            Debug.Log("平台：Open Source");
            return "OpenSource";
        #endif
    }
}
