using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public GameObject pausebtn;
    public GameObject pauseMenuUI;
    public static bool isPaused = false;

    void Start () {
        pauseMenuUI.SetActive(false);
 }





 
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                Resume();
            }
            else{
                
                Pause();
            }
        }
    }
    

    public void Resume(){
       pausebtn.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void Pause(){
        pausebtn.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void quitGame(){
        Application.Quit();
    }

}
