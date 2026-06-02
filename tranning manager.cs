using UnityEngine;

public class TrainingManager : MonoBehaviour {
    public Animator operaAnimator;
    public Animator singingAnimator;
    public Animator dramaAnimator;
    public Animator sportAnimator;

    public void Play(string type) {
        switch(type) {
            case "Opera": operaAnimator?.Play("OperaGestures"); break;
            case "Singing": singingAnimator?.Play("SingingActions"); break;
            case "Drama": dramaAnimator?.Play("DramaMoves"); break;
            case "Sport": sportAnimator?.Play("SportActions"); break;
        }
    }

    public float ComparePose(Transform studentJoint, Transform instructorJoint) {
        return Vector3.Angle(studentJoint.forward, instructorJoint.forward);
    }

    public void Feedback(float pitchDiff, float rhythmDiff, float motionDiff) {
        if (pitchDiff > 10 || rhythmDiff > 15 || motionDiff > 20) {
            Time.timeScale = 0;
            Debug.Log("請調整動作或音高，然後再繼續。");
        }
    }
}
