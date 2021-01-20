using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GOrders : MonoBehaviour
{
    private Color alphaNull;
    private GameObject bentoUI;
    public GameObject[] cookedContents;
    public GameObject cookedCont;
    private GameObject mechanics;
    public GCustomers customers;
    public Timer timers;
    public int genNewOrder;
    public bool newOrderActive = false;
    public int genCarb;
    public int genProtein;
    public int genFruit;
    public int genVeggie;
    public bool complete = false;

    public GameObject assemblyUI;
    public GameObject rawIngredientsUI;
    public GameObject cookedIngredientsUI;
    public string[] currentOrder;

    //contains the order (carb, proteim, side1 and side2) in text
    public List<string> order1 = new List<string>();
    public List<string> order2 = new List<string>();
    public List<string> order3 = new List<string>();
    public List<string> order4 = new List<string>();
    public List<string> order5 = new List<string>();

    //contains the ingredients that I added myself for the current order in sprite
    public string[] currentPlayerOrder;
    public int orderNumber;

    //just a memory variable for when I switch between order 1 and 5 (don't think we'll keep it)
    public string[] playerOrder1;
    public string[] playerOrder2;
    public string[] playerOrder3;
    public string[] playerOrder4;
    public string[] playerOrder5;

    // for customer animation...FAILED
    //public GameObject[] walkingCustomer;
    //private Animation walking;
    
    void Start(){
        alphaNull = new Color(1f, 1f, 1f, 0f);
        bentoUI = GameObject.Find("BentoDisplay");
        cookedCont = GameObject.Find("CookedContent");
        cookedContents = new GameObject[cookedCont.transform.childCount];
        mechanics = GameObject.Find("Mechanics");
        assemblyUI = GameObject.Find("AssemblyDisplay");
        rawIngredientsUI = GameObject.Find("RawIngredientsDisplay");
        cookedIngredientsUI = GameObject.Find("CookedIngredientsDisplay");
        rawIngredientsUI.SetActive(false);
        cookedIngredientsUI.SetActive(false);

        for (int i = 0; i < cookedContents.Length; i++)
        {  
            cookedContents[i] = cookedCont.transform.GetChild(i).gameObject;
        }

        //AssignOrder(NewOrder());
        currentOrder = order1.ToArray();
        orderNumber = 1;
        ResetALLPlayerOrder();

    }

    void Update()
    {
        if (customers.customersLost >= 3) {
                SceneManager.LoadScene(3);
            }
        //starts coroutine that creates a new customer / order
        if (newOrderActive == false) {
            StartCoroutine(OrderChance());
        }

        // player selects current order
        if (assemblyUI.activeSelf) {

            
            
            if (order1.Count > 0 && (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))) {
                currentOrder = order1.ToArray();
                orderNumber = 1;
                
            }

            if (order2.Count > 0 && (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))) {
                currentOrder = order2.ToArray();
                orderNumber = 2;
                
            }

            if (order3.Count > 0 && (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))) {
                currentOrder = order3.ToArray();
                orderNumber = 3;
                
            }

            if (order4.Count > 0 && (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))) {
                currentOrder = order4.ToArray();
                orderNumber = 4;
                
            }

            if (order5.Count > 0 && (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))) {
                currentOrder = order5.ToArray();
                orderNumber = 5;
                
            }
        }


        if (orderNumber == 1) {
            currentPlayerOrder = playerOrder1;
        }
        if (orderNumber == 2) {
            currentPlayerOrder = playerOrder2;
        }
        if (orderNumber == 3) {
            currentPlayerOrder = playerOrder3;
        }
        if (orderNumber == 4) {
            currentPlayerOrder = playerOrder4;
        }
        if (orderNumber == 5) {
            currentPlayerOrder = playerOrder5;
        }


        
        

        // activate submit order function
        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space)) {
            ConfirmOrder();
        }
    }



    // generates the chance for a new order
    IEnumerator OrderChance() {
        newOrderActive = true;
        genNewOrder = Random.Range(1, 6);
        if (true) {
            
            AssignOrder(NewOrder());
            yield return new WaitForSeconds(12);
             
        }
        newOrderActive = false;
        
    }
    // creates a random new order
    List<string> NewOrder(){
        List<string> orderList = new List<string>();
       
        genCarb = Random.Range(0, 2);
        if (genCarb == 1) {
            orderList.Add("Onigiri");
        }else {
             orderList.Add("Onigiri");
        }

        genProtein = Random.Range(0, 5);
        switch (genProtein)
        {
            case 0:
                orderList.Add("GrilledSalmon");
                break;
            
            case 1:
                orderList.Add("FriedChicken");
                break;
            
            case 2:
                orderList.Add("Tonkatsu");
                break;

            case 3:
                orderList.Add("BoiledEgg");
                break;
            
            case 4:
                orderList.Add("Steak");
                break;
        }

        genFruit = Random.Range(0, 5);
        switch (genFruit)
        {
            case 0:
                orderList.Add("Carrot");
                break;
            
            case 1:
                orderList.Add("Raddish");
                break;
            
            case 2:
                orderList.Add("CherryTomato");
                break;

            case 3:
                orderList.Add("BellPepper");
                break;
            
            case 4:
                orderList.Add("Broccoli");
                break;
        }

        genVeggie = Random.Range(0, 5);
        switch (genVeggie)
        {
            case 0:
                orderList.Add("Asparagus");
                break;
            
            case 1:
                orderList.Add("Edamame");
                break;
            
            case 2:
                orderList.Add("Salad");
                break;

            case 3:
                orderList.Add("Orange");
                break;
            
            case 4:
                orderList.Add("SweetPotato");
                break;
        }
        return orderList;
    }

    // assigns the new random order to an open order slot
    void AssignOrder(List<string> ranOrder){
        if (order1.Count == 0) {
            order1 = ranOrder;
        } 
        else {
            if (order2.Count == 0) {
                order2 = ranOrder;
                }
            else {
                if (order3.Count == 0) {
                order3 = ranOrder;
                }
                else{
                    if (order4.Count == 0) {
                    order4 = ranOrder;
                    }
                    else {
                        order5 = ranOrder;
                    }
                }
            }
        } 
        
    }

    void ResetALLPlayerOrder() {
        currentPlayerOrder = new string [4];
        playerOrder1 = new string [4];
        playerOrder2 = new string [4];
        playerOrder3 = new string [4];
        playerOrder4 = new string [4];
        playerOrder5 = new string [4];
    }


/*    Tried to animate, but couldnt get it to work
    void AnimateWalking(GameObject walkingOrder) {
        walking = walkingOrder.GetComponent<Animation>();
        walking.Play("Walking02");
    }
*/


    /*
    void CreatePlayerOrder(string[] curOrder) {
        // player creates order.
            // Carbs
            if (Input.GetKeyDown(KeyCode.C)) {
                
                assemblyUI.SetActive(false);
                carbUI.SetActive(true);

                
            }

            if (carbUI.activeSelf && (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))) {
                    
                    curOrder[0] = "Rice";
                    carbUI.SetActive(false);
                    assemblyUI.SetActive(true);
                
                
            }
            if (carbUI.activeSelf && (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))) {
                    
                    curOrder[0] = "Bread";
                    carbUI.SetActive(false);
                    assemblyUI.SetActive(true);
            }
            if (carbUI.activeSelf && Input.GetKeyDown(KeyCode.Escape)) {
                
                assemblyUI.SetActive(true);
                carbUI.SetActive(false);
            }

            // Proteins
            if (Input.GetKeyDown(KeyCode.T)) {

                assemblyUI.SetActive(false);
                proteinUI.SetActive(true);
                
                
            }

            if (proteinUI.activeSelf && (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))) {
                    curOrder[1] = "Salmon";
                    proteinUI.SetActive(false);
                    assemblyUI.SetActive(true);
            }
            if (proteinUI.activeSelf && (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))) {
                    curOrder[1] = "Steak";
                    proteinUI.SetActive(false);
                    assemblyUI.SetActive(true);
            }
            if (proteinUI.activeSelf && Input.GetKeyDown(KeyCode.Escape)) {
                proteinUI.SetActive(false);
                assemblyUI.SetActive(true);
            }

            //Fruits
            if (Input.GetKeyDown(KeyCode.F)) {

                assemblyUI.SetActive(false);
                fruitUI.SetActive(true);

                
            }

            if (fruitUI.activeSelf && (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))) {
        
                    curOrder[2] = "Strawberry";
                    fruitUI.SetActive(false);
                    assemblyUI.SetActive(true);
                
            }
            if (fruitUI.activeSelf && (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))) {
                
                    curOrder[2] = "Orange";
                    fruitUI.SetActive(false);
                    assemblyUI.SetActive(true);
                
            }
            if (fruitUI.activeSelf && Input.GetKeyDown(KeyCode.Escape)) {
                fruitUI.SetActive(false);
                assemblyUI.SetActive(true);
            }


            // veggies
            if (Input.GetKeyDown(KeyCode.V)) {

                assemblyUI.SetActive(false);
                veggieUI.SetActive(true);

                
            }

            if (veggieUI.activeSelf && (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))) {
                
                    curOrder[3] = "Broccoli";
                    veggieUI.SetActive(false);
                    assemblyUI.SetActive(true);
                
            }
            if (veggieUI.activeSelf && (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))) {
                
                    curOrder[3] = "Carrot";
                    veggieUI.SetActive(false);
                    assemblyUI.SetActive(true);
                
            }
            if (veggieUI.activeSelf && Input.GetKeyDown(KeyCode.Escape)) {
                veggieUI.SetActive(false);
                assemblyUI.SetActive(true);
            }
    }
    */
    


    // determines if an order is complete
    bool SubmitOrder(string[] currentOrder, string[] plOrder) {
        if (GameObject.Find("BentoBoxOrder").GetComponent<Text>().text != I18n.Fields["BentoBoxOrder"]+"---")
        {
            for (int i = 0; i < currentOrder.Length; i++){
                if (currentOrder[i] != plOrder[i]) {
                    return false;
                }
            }
            return true; 
        }else
        {
            return false;
        }
          
    }

    //Saito

    public void RawIngredientsUI(){
        FindObjectOfType<AudioManager>().Play("Selection");
        if (!rawIngredientsUI.activeSelf)
        {   cookedIngredientsUI.SetActive(false);
            rawIngredientsUI.SetActive(true);
        }
        else
        {
            rawIngredientsUI.SetActive(false);
        }
    }

    public void CookedIngredientsUI(){
        FindObjectOfType<AudioManager>().Play("Selection");
        if (!cookedIngredientsUI.activeSelf)
        {   
            rawIngredientsUI.SetActive(false);
            cookedIngredientsUI.SetActive(true);
            for (int i = 0; i < cookedContents.Length; i++)
            {
                //when clicking on the CookedIngredientButton, update the color and the number of cooked ingredients
                if (i%2 == 0)
                {   
                    cookedCont.transform.GetChild(i).GetComponent<Image>().color = mechanics.GetComponent<GOrders>().cookedContents[i].GetComponent<Image>().color; //aplhaNull
                }
                else
                {
                    cookedCont.transform.GetChild(i).GetComponent<Text>().text = cookedContents[i].GetComponent<Text>().text;
                }
            }
        }
        else
        {
            cookedIngredientsUI.SetActive(false);
        }
    }


    /*
    public void ChooseIngredient(){
        if (carbUI.activeSelf == true)
        {
            if (EventSystem.current.currentSelectedGameObject.name == "Rice1")
            {
                    
            }
            else if (EventSystem.current.currentSelectedGameObject.name == "Bread2")
            {
                currentPlayerOrder[0] = "Bread";
            }
            carbUI.SetActive(false);
            assemblyUI.SetActive(true);
        }

        else if (proteinUI.activeSelf == true)
        {
            if (EventSystem.current.currentSelectedGameObject.name == "Salmon1")
            {
                currentPlayerOrder[1] = "Salmon";
            }
            else if (EventSystem.current.currentSelectedGameObject.name == "Steak2")
            {
                currentPlayerOrder[1] = "Steak";
            }
            proteinUI.SetActive(false);
            assemblyUI.SetActive(true);
        }

        else if (fruitUI.activeSelf == true)
        {
            if (EventSystem.current.currentSelectedGameObject.name == "Strawberry1")
            {
                currentPlayerOrder[2] = "Strawberry";
            }
            else if (EventSystem.current.currentSelectedGameObject.name == "Orange2")
            {
                currentPlayerOrder[2] = "Orange";
            }
            fruitUI.SetActive(false);
            assemblyUI.SetActive(true);
        }

        else if (veggieUI.activeSelf == true)
        {
            if (EventSystem.current.currentSelectedGameObject.name == "Broccoli1")
            {
                currentPlayerOrder[3] = "Broccoli";
            }
            else if (EventSystem.current.currentSelectedGameObject.name == "Carrot2")
            {
                currentPlayerOrder[3] = "Carrot";
            }
            veggieUI.SetActive(false);
            assemblyUI.SetActive(true);
        }
            
    }
    */

    public void ConfirmOrder(){
        for (int i = 0; i < 4; i++)
        {
            //prevent the error of when there's for example a side in the bento (3rd place) and no Carb in the bento (1st place), just an error of nullException and it's going by order.
            if (bentoUI.transform.GetChild(i).GetComponent<Image>().sprite)
            {
                //when you hit the serveButton, all the ingredient from  the bentoUI turn transparent
                bentoUI.transform.GetChild(i).GetComponent<Image>().color = alphaNull;
                currentPlayerOrder[i] = bentoUI.transform.GetChild(i).GetComponent<Image>().sprite.name;
            }
        }
        if(SubmitOrder(currentOrder, currentPlayerOrder)) {
            //remove 1 from customers remaining
            customers.customersRemaining --;
            // if player wins, take to win screen
            Debug.Log(customers.customersRemaining);
            if (customers.customersRemaining == 0) {
                Debug.Log(Difficulty.level);
                if (Difficulty.level == 3)
                {
                    Debug.Log("Maybe");
                    SceneManager.LoadScene(5);
                    Debug.Log("not");
                }
                else
                {
                    Difficulty.level++;
                    Debug.Log("why");
                    SceneManager.LoadScene(2);
                }
            }
            FindObjectOfType<AudioManager>().Play("OrderRightSFX");

            // remove current order
            // remove player order
            // remove the order current order relates to
            if (orderNumber == 1) {
                order1.Clear();
                timers.timerIsRunning1 = false;
                timers.timeRemaining1 = Difficulty.timerDifficulty;
                currentOrder = order1.ToArray();
                playerOrder1 = new string[4];
                currentPlayerOrder = new string [4];
            }
            if (orderNumber == 2) {
                order2.Clear();
                timers.timerIsRunning2 = false;
                timers.timeRemaining2 = Difficulty.timerDifficulty;
                currentOrder = order2.ToArray();
                playerOrder2 = new string[4];
                currentPlayerOrder = new string [4];
            }
            if (orderNumber == 3) {
                order3.Clear();
                timers.timerIsRunning3 = false;
                timers.timeRemaining3 = Difficulty.timerDifficulty;
                currentOrder = order3.ToArray();
                playerOrder3 = new string[4];
                currentPlayerOrder = new string [4];
            }
            if (orderNumber == 4) {
                order4.Clear();
                timers.timerIsRunning4 = false;
                timers.timeRemaining4 = Difficulty.timerDifficulty;
                currentOrder = order4.ToArray();
                playerOrder4 = new string[4];
                currentPlayerOrder = new string [4];
            }
            if (orderNumber == 5) {
                order5.Clear();
                timers.timerIsRunning5 = false;
                timers.timeRemaining5 = Difficulty.timerDifficulty;
                currentOrder = order5.ToArray();
                playerOrder5 = new string[4];
                currentPlayerOrder = new string [4];
            }
        }
        else{
            //Debug.Log("incorrect order");
            FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
            switch (orderNumber)
            {
                case 1:
                    playerOrder1 = new string[4];
                    currentPlayerOrder = new string [4];
                    break;

                case 2:
                    playerOrder2 = new string[4];
                    currentPlayerOrder = new string [4];
                    break;

                case 3:
                    playerOrder3 = new string[4];
                    currentPlayerOrder = new string [4];
                    break;

                case 4:
                    playerOrder4 = new string[4];
                    currentPlayerOrder = new string [4];
                    break;

                case 5:
                    playerOrder5 = new string[4];
                    currentPlayerOrder = new string [4];
                    break;

                default:
                    break;
            }
        }
    }

}
