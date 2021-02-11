
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collision collision){
        Destroy(collision.gameObject);
        Debug.Log("help");
    }
}
