using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class OnClickTimer : MonoBehaviour, IPointerClickHandler
{

    private GOrders gOrders;
    private string timeClicked;
    // Start is called before the first frame update
    void Start()
    {
        gOrders = GameObject.Find("Mechanics").GetComponent<GOrders>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData){
        timeClicked = eventData.pointerCurrentRaycast.gameObject.name;
        //Debug.Log(timeClicked);
        if (timeClicked.Contains("Order1") && gOrders.order1.Count > 0)
        {
            gOrders.currentOrder = gOrders.order1.ToArray();
            gOrders.orderNumber = 1;
        }
        else if (timeClicked.Contains("Order2") && gOrders.order2.Count > 0)
        {
            gOrders.currentOrder = gOrders.order2.ToArray();
            gOrders.orderNumber = 2;
        }
        else if (timeClicked.Contains("Order3") && gOrders.order3.Count > 0)
        {
            gOrders.currentOrder = gOrders.order3.ToArray();
            gOrders.orderNumber = 3;
        }
        else if (timeClicked.Contains("Order4") && gOrders.order4.Count > 0)
        {
            gOrders.currentOrder = gOrders.order4.ToArray();
            gOrders.orderNumber = 4;
        }
        else if (timeClicked.Contains("Order5") && gOrders.order5.Count > 0)
        {
            gOrders.currentOrder = gOrders.order5.ToArray();
            gOrders.orderNumber = 5;
        }

    }
}
