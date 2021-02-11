
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{   
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Respawn"){
            Debug.Log("HEYY");
        }
    }
}
