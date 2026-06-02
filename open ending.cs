using UnityEngine;

public class OpenEnding : MonoBehaviour {
    public void AddNewCharacter(string characterName, Animator animator, string animationClip) {
        if (animator != null) {
            animator.Play(animationClip);
            Debug.Log($"{characterName} 已加入並播放 {animationClip}");
        } else {
            Debug.LogError($"{characterName} Animator 未綁定！");
        }
    }
}
