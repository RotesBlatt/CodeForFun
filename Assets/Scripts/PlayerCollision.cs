
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{   
    void Update(){
        if(Input.GetKey(KeyCode.R)){
            alla();
        }
    }
    
    // private void OnControllerColliderHit(ControllerColliderHit hit) {
    //     Debug.Log("ASDAD");
    // }
    public void alla(){
        Debug.Log("AALALAL");
    }
}
