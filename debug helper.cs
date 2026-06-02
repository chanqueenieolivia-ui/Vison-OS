using UnityEngine;

public class DebugHelper : MonoBehaviour {
    public static void CheckAnimator(Animator animator, string name) {
        if (animator == null) { Debug.LogError($"Animator for {name} 未綁定！"); }
    }
    public static void CheckScene(string sceneName) {
        if (!Application.CanStreamedLevelBeLoaded(sceneName)) {
            Debug.LogError($"場景 {sceneName} 未找到！");
        }
    }
    public static void CheckModel(GameObject model, string name) {
        if (model == null) { Debug.LogError($"模型 {name} 未載入！"); }
    }
}
