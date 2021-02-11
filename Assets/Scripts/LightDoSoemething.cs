using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDoSoemething : MonoBehaviour
{   
    public float rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rotation >= 200){
            rotation = -20f;
        }

        rotation += 0.005f;
        //directionalLight.transform.Rotate(0f, rotation, 0f);

        transform.localRotation = Quaternion.Euler(rotation, 0f, 0f);

        //transform.Rotate(Vector3.up * Time.deltaTime);

    }

    public void setRotation(float x){
        rotation = x;
    }
}
