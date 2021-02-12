using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishGame : MonoBehaviour
{
    public void EndGame(){
        SceneManager.LoadScene("EndScreen");
    }
}
