using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCollision : MonoBehaviour
{
    public bool isNear = false;

    public float bedCd;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //
        GameObject gameObject = GameObject.Find("Directional Light");
        LightDoSoemething light = gameObject.GetComponent<LightDoSoemething>();
        

        if(isNear && Input.GetKey(KeyCode.E) && bedCd <= 0){
            light.setRotation(Random.Range(40, 160));
            bedCd = 1;
            //Debug.Log("E");
        }

        if(bedCd > 0){
            bedCd -= 1 * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision other) {
        Debug.Log("Geh rein");
        isNear = true;
    }

    // private void OnCollisionStay(Collision other) {
    //     Debug.Log("Bin Drin");
    // }

    private void OnCollisionExit(Collision other) {
        Debug.Log("Bin raus");
        isNear = false;
    }

    // private void OnControllerColliderHit(ControllerColliderHit hit) {
    //     Debug.Log("Cheese");
    // }
}
