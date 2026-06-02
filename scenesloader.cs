using UnityEngine;

public class SceneLoader : MonoBehaviour {
    public void LoadTrainingScene(string type) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(type + "Scene");
    }
}
