using UnityEngine;

public class RealTimeFeedback : MonoBehaviour {
    public void ComparePerformance(float pitchDiff, float rhythmDiff, float motionDiff) {
        if (pitchDiff > 10 || rhythmDiff > 15 || motionDiff > 20) {
            PauseTraining();
            ShowCorrectionTips();
        }
    }

    private void PauseTraining() {
        Time.timeScale = 0;
    }

    private void ShowCorrectionTips() {
        Debug.Log("請調整動作或音高，然後再繼續。");
    }
}
