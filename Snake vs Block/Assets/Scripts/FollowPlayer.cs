using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Target;
    private float offsetZ = 2; 
    private void LateUpdate()
    {
        Vector3 trasformPos = transform.position;
        trasformPos.z = Target.position.z - offsetZ;
        transform.position = trasformPos;
    }
}
