
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision){
        Destroy(collision.gameObject);
        Debug.Log("help");
    }
}
