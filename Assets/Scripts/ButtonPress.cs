using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    bool isInRange;
    public bool buttonPressed;
    public int ID;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // GameObject gameObject = GameObject.Find("Door");
        //Door pressButton = gameObject.GetComponent<Door>();

        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Button Pressed");

            //pressButton.DeleteDoor(ID);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "First Person Player")
        {
            Debug.Log("alla ez");
            isInRange = true;
        }
    }

      private void OnTriggerStay(Collider other) {
        
    }

    private void OnTriggerExit(Collider other)
    {
        isInRange = false;
    }
}
