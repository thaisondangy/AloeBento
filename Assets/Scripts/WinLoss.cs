using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoss : MonoBehaviour
{
    
    public GCustomers customers;
    public GOrders orders;

   void Update() {
        // if player loses, take to loss screen
        if (customers.customersLost >= 3) {
            SceneManager.LoadScene(3);   
        }

        // if player wins, take to win screen
        if (customers.customersRemaining == 0) {
            SceneManager.LoadScene(2);
        }
    }
}
