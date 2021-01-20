using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GCustomers customers;
    public GOrders globalorders;
    public float timeRemaining1;
    public float timeRemaining2;
    public float timeRemaining3;
    public float timeRemaining4;
    public float timeRemaining5;
    public bool timerIsRunning1 = false;
    public bool timerIsRunning2 = false;
    public bool timerIsRunning3 = false;
    public bool timerIsRunning4 = false;
    public bool timerIsRunning5 = false;
    public GameObject timer1;
    public GameObject timer2;
    public GameObject timer3;
    public GameObject timer4;
    public GameObject timer5;
    public int whichTimer;

    void Start() {
        timeRemaining1 = Difficulty.timerDifficulty;
        timeRemaining2 = Difficulty.timerDifficulty;
        timeRemaining3 = Difficulty.timerDifficulty;
        timeRemaining4 = Difficulty.timerDifficulty;
        timeRemaining5 = Difficulty.timerDifficulty;
        whichTimer = 0;
    }

    void Update() 
    {
        // starts the timers when an order is created
        if (globalorders.order1.Count > 0) {
            timerIsRunning1 = true;
            if (globalorders.orderNumber == 1)
            {
                globalorders.currentOrder = globalorders.order1.ToArray();
            }
        }
        else{
            timer1.GetComponent<Text>().text = "---";
        }

        if (globalorders.order2.Count > 0) {
            timerIsRunning2 = true;
            if (globalorders.orderNumber == 2)
            {
                globalorders.currentOrder = globalorders.order2.ToArray();
            }
        }
         else{
            timer2.GetComponent<Text>().text = "---";
        }
        if (globalorders.order3.Count > 0) {
            timerIsRunning3 = true;
            if (globalorders.orderNumber == 3)
            {
                globalorders.currentOrder = globalorders.order3.ToArray();
            }
        }
         else{
            timer3.GetComponent<Text>().text = "---";
        }
        if (globalorders.order4.Count > 0) {
            timerIsRunning4 = true;
            if (globalorders.orderNumber == 4)
            {
                globalorders.currentOrder = globalorders.order4.ToArray();
            }
        }
         else{
            timer4.GetComponent<Text>().text = "---";
        }
        if (globalorders.order5.Count > 0) {
            timerIsRunning5 = true;
            if (globalorders.orderNumber == 5)
            {
                globalorders.currentOrder = globalorders.order5.ToArray();
            }
        }
         else{
            timer5.GetComponent<Text>().text = "---";
        }


        // timer countdown code for each timer

        if (timerIsRunning1)
        {
            if (timeRemaining1 > 0)
            {
                timeRemaining1 -= Time.deltaTime;
                DisplayTime(timeRemaining1, timer1);
            }
            else
            {
                Debug.Log("Time has run out!");
                customers.customersLost ++;
                timerIsRunning1 = false;
                timeRemaining1 = Difficulty.timerDifficulty;
                globalorders.order1.Clear();
                if (globalorders.orderNumber == 1)
                {
                    globalorders.currentOrder = globalorders.order1.ToArray();
                }
            }
        }

        if (timerIsRunning2)
        {
            if (timeRemaining2 > 0)
            {
                timeRemaining2 -= Time.deltaTime;
                DisplayTime(timeRemaining2, timer2);
            }
            else
            {
                Debug.Log("Time has run out!");
                customers.customersLost ++;
                timerIsRunning2 = false;
                timeRemaining2 = Difficulty.timerDifficulty;
                globalorders.order2.Clear();
                if (globalorders.orderNumber == 2)
                {
                    globalorders.currentOrder = globalorders.order2.ToArray();
                }
            }
        }

        if (timerIsRunning3)
        {
            if (timeRemaining3 > 0)
            {
                timeRemaining3 -= Time.deltaTime;
                DisplayTime(timeRemaining3, timer3);
            }
            else
            {
                Debug.Log("Time has run out!");
                customers.customersLost ++;
                timerIsRunning3 = false;
                timeRemaining3 = Difficulty.timerDifficulty;
                globalorders.order3.Clear();
                if (globalorders.orderNumber == 3)
                {
                    globalorders.currentOrder = globalorders.order3.ToArray();
                }
            }
        }

        if (timerIsRunning4)
        {
            if (timeRemaining4 > 0)
            {
                timeRemaining4 -= Time.deltaTime;
                DisplayTime(timeRemaining4, timer4);
            }
            else
            {
                Debug.Log("Time has run out!");
                customers.customersLost ++;
                timerIsRunning4 = false;
                timeRemaining4 = Difficulty.timerDifficulty;
                globalorders.order4.Clear();
                if (globalorders.orderNumber == 4)
                {
                    globalorders.currentOrder = globalorders.order4.ToArray();
                }
            }
        }

        if (timerIsRunning5)
        {
            if (timeRemaining5 > 0)
            {
                timeRemaining5 -= Time.deltaTime;
                DisplayTime(timeRemaining5, timer5);
            }
            else
            {
                Debug.Log("Time has run out!");
                customers.customersLost ++;
                timerIsRunning5 = false;
                timeRemaining5 = Difficulty.timerDifficulty;
                globalorders.order5.Clear();
                if (globalorders.orderNumber == 5)
                {
                    globalorders.currentOrder = globalorders.order5.ToArray();
                }
            }
        }
    }

    // replaces text with time format

    void DisplayTime(float timeToDisplay, GameObject timer)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timer.GetComponent<Text>().text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

    
}
