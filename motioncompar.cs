using UnityEngine;

public class MotionComparer : MonoBehaviour {
    public float ComparePose(Transform studentJoint, Transform instructorJoint) {
        return Vector3.Angle(studentJoint.forward, instructorJoint.forward);
    }
}
