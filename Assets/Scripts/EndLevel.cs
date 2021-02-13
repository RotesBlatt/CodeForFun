using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameManager gameManager;


    // void Start(){
    //     gameManager = GetComponent<GameManager>();
    // }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player"){
            gameManager.finishGame();
        }
    }
}
