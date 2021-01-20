﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgt : MonoBehaviour
{


    public bool IsLoading = false;

    

    public void NewGame() {
        SceneManager.LoadScene(1);
    }

    public void MainMenu() {
        SceneManager.LoadScene(0);
    }

    public void Credits() {
        SceneManager.LoadScene(4);
    }

    
}
