using UnityEngine;

public class CharacterBinder : MonoBehaviour {
    public Animator operaAnimator;
    public Animator singingAnimator;
    public Animator dramaAnimator;
    public Animator sportAnimator;

    public void PlayOpera() {
        operaAnimator.Play("OperaGestures");
    }

    public void PlaySinging() {
        singingAnimator.Play("SingingActions");
    }

    public void PlayDrama() {
        dramaAnimator.Play("DramaMoves");
    }

    public void PlaySport() {
        sportAnimator.Play("SportActions");
    }
}
