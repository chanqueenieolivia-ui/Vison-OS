using UnityEngine;

public class MainMenuController : MonoBehaviour {
    public SceneLoader sceneLoader;

    public void SelectOpera() {
        sceneLoader.LoadTrainingScene("Opera");
    }

    public void SelectSinging() {
        sceneLoader.LoadTrainingScene("Singing");
    }

    public void SelectDrama() {
        sceneLoader.LoadTrainingScene("Drama");
    }

    public void SelectSport() {
        sceneLoader.LoadTrainingScene("Sport");
    }
}
