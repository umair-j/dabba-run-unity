﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenu : MonoBehaviour
{
    public void startGame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
