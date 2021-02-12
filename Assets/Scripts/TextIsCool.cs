using UnityEngine;
using UnityEngine.UI;

public class TextIsCool : MonoBehaviour
{
    public Text cDText; 


    // Update is called once per frame
    void Update()
    {

        if(FindObjectOfType<ThirdPersonCollision>().bedCd > 0){
            cDText.text = FindObjectOfType<ThirdPersonCollision>().getBedCd().ToString("0");
            
        } else {
            cDText.text = "Ready";   
        }
    }
}
