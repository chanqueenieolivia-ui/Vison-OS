using UnityEngine;

public class InstructorDemo : MonoBehaviour {
    public Animator instructorAnimator;

    public void PlayDemo(string actionName) {
        instructorAnimator.Play(actionName);
    }
}
