using UnityEngine;

public class EndLevel : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            FindObjectOfType<GameManager>().finishGame();
        }
    }
}
