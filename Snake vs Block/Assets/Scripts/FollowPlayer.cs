using UnityEngine;
using UnityEngine.SceneManagement;
public class FollowPlayer : MonoBehaviour
{
    public Transform Target;
    private float offsetZ = 2;
    public Game _game;
    
    private void LateUpdate()
    {
        if (Target == null)
        {
           _game.OnPlayerDied();
        }
            
        else
        {
            Vector3 trasformPos = transform.position;
            trasformPos.z = Target.position.z - offsetZ;
            transform.position = trasformPos;
        }
        
    }
}
