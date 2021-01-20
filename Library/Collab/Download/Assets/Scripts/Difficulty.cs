using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    [HideInInspector]
    public static int level;

    [HideInInspector]
    public static int customer;

    [HideInInspector]
    public static float timerDifficulty;

    void Awake(){
        level = 1;
        customer = 1;
        timerDifficulty = 90;
        DontDestroyOnLoad(this.gameObject);
    }
    
    void Update(){
        switch (level)
        {
            case 1:
                customer = 15;
                timerDifficulty = 45;
                break;

            case 2:
                customer = 10;
                timerDifficulty = 60;
                break;

            case 3:
                customer = 5;
                timerDifficulty = 90;
                break;
        }
    }
}
