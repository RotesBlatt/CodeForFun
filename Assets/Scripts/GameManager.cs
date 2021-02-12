using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    
    public GameObject finishGamelUI;

    public float restartDelay = 1f;


    public void finishGame(){
        finishGamelUI.SetActive(true);
    }
     
    public void EndGame(){
        if(gameEnded == false){
            gameEnded =  true;
            Debug.Log("Game Over");
            Invoke("End", restartDelay);
        }
    }

    void End(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
