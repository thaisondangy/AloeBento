using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatDisplay : MonoBehaviour
{
    public GameObject rawButton, cookedButton, serveButton, customersRemainingDisplay, customersLostDisplay, levelDisplay;
    public GCustomers customers;

    public Difficulty difficulty;

    // Update is called once per frame
    void Update()
    {
        customersRemainingDisplay.GetComponent<Text>().text = I18n.Fields["CustomersLeft"] + customers.customersRemaining;
        customersLostDisplay.GetComponent<Text>().text = I18n.Fields["CustomersLost"] + customers.customersLost;
        levelDisplay.GetComponent<Text>().text = I18n.Fields["Level"] + Difficulty.level;
        rawButton.GetComponent<Text>().text = I18n.Fields["RawIngredients"];
        cookedButton.GetComponent<Text>().text = I18n.Fields["CookedIngredients"];
        serveButton.GetComponent<Text>().text = I18n.Fields["Serve"];
    }
}
