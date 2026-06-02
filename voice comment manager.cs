using UnityEngine;

public class VoiceCommandManager : MonoBehaviour {
    public SceneLoader sceneLoader;

    public void ProcessCommand(string command) {
        switch(command.ToLower()) {
            case "opera": case "粵劇": sceneLoader.LoadTrainingScene("Opera"); break;
            case "singing": case "歌唱": sceneLoader.LoadTrainingScene("Singing"); break;
            case "drama": case "話劇": sceneLoader.LoadTrainingScene("Drama"); break;
            case "sport": case "運動": sceneLoader.LoadTrainingScene("Sport"); break;
            default: Debug.Log("未識別指令，請再試一次。"); break;
        }
    }
}
