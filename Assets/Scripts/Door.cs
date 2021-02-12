using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int ID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeleteDoor(int x)
    {
        if(x == ID)
        {
            Destroy(gameObject);
        }
    }
}
