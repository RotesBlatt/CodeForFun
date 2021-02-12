using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThirdPersonCollision : MonoBehaviour
{
    public bool isNear = false;

    public float bedCd;

    // Update is called once per frame
    void Update()
    {       
        if(isNear && Input.GetKeyDown(KeyCode.E) && bedCd <= 0){
            FindObjectOfType<LightDoSoemething>().setRotation(Random.Range(40, 160));
            bedCd = 5;
            //Debug.Log("E");
        }

        if(bedCd > 0){
            bedCd -= 1 * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other) {
        isNear = true;
        //Debug.Log("YES");
    }

    // private void OnTriggerStay(Collider other) {
    //     isNear = true;
    //     Debug.Log("Hold my Beer");
    // }

    private void OnTriggerExit(Collider other) {
        isNear = false;
        //Debug.Log("No");
    }

    public float getBedCd(){
        return bedCd;
    }
}
