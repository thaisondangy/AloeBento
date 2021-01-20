using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderDisplay : MonoBehaviour
{
    private Timer timer;
    public GOrders orders;
    public GameObject bentoBoxOrderNumber;
    public GameObject carbDisplay;
    public GameObject proteinDisplay;
    public GameObject fruitDisplay;
    public GameObject veggieDisplay;

    private Image[] foodDisplay;
    private GameObject test;

  
    void Start(){
        
        timer = GameObject.Find("Mechanics").GetComponent<Timer>();
        foodDisplay = new Image[4];
        foodDisplay[0] = GameObject.Find("CarbImage").GetComponent<Image>();
        foodDisplay[1] = GameObject.Find("ProteinImage").GetComponent<Image>();
        foodDisplay[2] = GameObject.Find("FruitImage").GetComponent<Image>();
        foodDisplay[3] = GameObject.Find("VeggieImage").GetComponent<Image>();
    }

    void Update() {

        // displays the current order
        if (orders.currentOrder.Length == 0)
        {
            bentoBoxOrderNumber.GetComponent<Text>().text = I18n.Fields["BentoBoxOrder"]+"---";
            carbDisplay.GetComponent<Text>().text = "---";
            proteinDisplay.GetComponent<Text>().text = "---";
            fruitDisplay.GetComponent<Text>().text = "---";
            veggieDisplay.GetComponent<Text>().text = "---";
            for (int i = 0; i < 4; i++)
            {
                foodDisplay[i].gameObject.SetActive(false);
            }
        }
        else
        {
            bentoBoxOrderNumber.GetComponent<Text>().text = I18n.Fields["BentoBoxOrder"] + orders.orderNumber;
            carbDisplay.GetComponent<Text>().text = I18n.Fields[orders.currentOrder[0]];
            proteinDisplay.GetComponent<Text>().text = I18n.Fields[orders.currentOrder[1]];
            fruitDisplay.GetComponent<Text>().text = I18n.Fields[orders.currentOrder[2]];
            veggieDisplay.GetComponent<Text>().text = I18n.Fields[orders.currentOrder[3]];
            for (int i = 0; i < 4; i++)
            {
                foodDisplay[i].gameObject.SetActive(true);
                foodDisplay[i].sprite = Resources.Load<Sprite>("Sprites/"+orders.currentOrder[i]);
            }
        }

        /*
        if (orders.currentOrder.Length == 0)
        {
            if (!(timer.timerIsRunning1 || timer.timerIsRunning2 || timer.timerIsRunning3 || timer.timerIsRunning4 || timer.timerIsRunning5))
            {
                if (!timer.timerIsRunning1)
                {
                    bentoBoxOrderNumber.GetComponent<Text>().text = I18n.Fields["BentoBoxOrder"]+"---";
                    carbDisplay.GetComponent<Text>().text = "---";
                    proteinDisplay.GetComponent<Text>().text = "---";
                    fruitDisplay.GetComponent<Text>().text = "---";
                    veggieDisplay.GetComponent<Text>().text = "---";
                    for (int i = 0; i < 4; i++)
                    {
                        foodDisplay[i].gameObject.SetActive(false);
                    }
                }
            }
            bentoBoxOrderNumber.GetComponent<Text>().text = I18n.Fields["BentoBoxOrder"]+"---";
            carbDisplay.GetComponent<Text>().text = "---";
            proteinDisplay.GetComponent<Text>().text = "---";
            fruitDisplay.GetComponent<Text>().text = "---";
            veggieDisplay.GetComponent<Text>().text = "---";
            for (int i = 0; i < 4; i++)
            {
                foodDisplay[i].gameObject.SetActive(false);
            }
        }
        else
        {
            bentoBoxOrderNumber.GetComponent<Text>().text = I18n.Fields["BentoBoxOrder"] + orders.orderNumber;
            carbDisplay.GetComponent<Text>().text = I18n.Fields[orders.currentOrder[0]];
            proteinDisplay.GetComponent<Text>().text = I18n.Fields[orders.currentOrder[1]];
            fruitDisplay.GetComponent<Text>().text = I18n.Fields[orders.currentOrder[2]];
            veggieDisplay.GetComponent<Text>().text = I18n.Fields[orders.currentOrder[3]];
            for (int i = 0; i < 4; i++)
            {
                foodDisplay[i].gameObject.SetActive(true);
                foodDisplay[i].sprite = Resources.Load<Sprite>("Sprites/"+orders.currentOrder[i]);
            }
        }*/
        
    }
}
