using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCustomers : MonoBehaviour
{
    public int customersRemaining;
    public int customersLost;

    

    void Start() {
        customersRemaining = Difficulty.customer;
        customersLost = 0;
    }

}
