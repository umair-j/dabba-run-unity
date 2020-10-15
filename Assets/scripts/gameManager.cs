using UnityEngine;
using UnityEngine.SceneManagement;


public class gameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    bool gameEnded = false;
    public GameObject completeLevelUI;
    public void levelComplete(){
        
        completeLevelUI.SetActive(true);
    }


    public void endGame(){
        if(gameEnded==false)
            {
                gameEnded = true;
                Debug.Log("game over");
                Invoke("restart",restartDelay);
            }
    }
    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
