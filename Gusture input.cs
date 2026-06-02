using UnityEngine;

public class GestureInput : MonoBehaviour {
    public SceneLoader sceneLoader;

    public void DetectGesture(string gesture) {
        switch(gesture) {
            case "swipe_left": sceneLoader.LoadTrainingScene("Opera"); break;
            case "swipe_right": sceneLoader.LoadTrainingScene("Sport"); break;
            case "point_up": sceneLoader.LoadTrainingScene("Singing"); break;
            case "point_down": sceneLoader.LoadTrainingScene("Drama"); break;
            default: Debug.Log("未知手勢"); break;
        }
    }
}
