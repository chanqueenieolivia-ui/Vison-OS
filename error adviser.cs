using UnityEngine;

public class ErrorAdvisor : MonoBehaviour {
    public static void CheckAnimator(Animator animator, string name) {
        if (animator == null) {
            Debug.LogError($"Animator for {name} 未綁定！請檢查 Animator Controller。");
        }
    }
    public static void CheckScene(string sceneName) {
        if (!Application.CanStreamedLevelBeLoaded(sceneName)) {
            Debug.LogError($"場景 {sceneName} 未找到！請確認已加入 Build Settings。");
        }
    }
    public static void CheckModel(GameObject model, string name) {
        if (model == null) {
            Debug.LogError($"模型 {name} 未載入！請檢查 FBX 檔案路徑。");
        }
    }
}
