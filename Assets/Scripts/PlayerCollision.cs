
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnTriggerEvent(Collider other)
    {
        if(other.tag == "CollisionTest")
        {
            Debug.Log("Collision Detected");
        }
    }
}
