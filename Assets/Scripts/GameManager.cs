using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    
    public GameObject finishGameUI;

    public float restartDelay = 1f;


    public void finishGame(){
        finishGameUI.SetActive(true);
    }
     
    public void EndGame(){
        if(gameEnded == false){
            gameEnded =  true;
            Debug.Log("Game Over");
            Invoke("End", restartDelay);
        }
    }

    public void RestartGame(){
        Invoke("Restart", restartDelay);
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void End(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
