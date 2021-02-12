using UnityEngine;
using UnityEngine.UI;

public class TextIsCool : MonoBehaviour
{
    public Text cDText; 

    // Update is called once per frame
    void Update()
    {
        GameObject gameObject = GameObject.Find("Bed_Trigger");
        ThirdPersonCollision third = gameObject.GetComponent<ThirdPersonCollision>();

        if(third.bedCd > 0){
            cDText.text = third.getBedCd().ToString("0");
        } else {
            cDText.text = "Ready";   
        }
    }
}
