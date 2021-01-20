using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnClickImage : MonoBehaviour, IPointerClickHandler
{
    private GameObject bentoUI;
    private GOrders gOrders;
    private GameObject bentoOrder;
    private string ingredientName;
    private Color alphaNull, alphaHalf, alphaFull;

    private void Start(){
        bentoUI = GameObject.Find("BentoDisplay");
        gOrders = GameObject.Find("Mechanics").GetComponent<GOrders>();
        bentoOrder = GameObject.Find("BentoBoxOrder");
        alphaNull = new Color(1f, 1f, 1f, 0f);
        alphaHalf = new Color(1f, 1f, 1f, 0.5f);
        alphaFull = new Color(1f, 1f, 1f, 1f);
    }

    //to further work on it (do the necessary changes)
    public void OnPointerClick(PointerEventData eventData){
        ingredientName = eventData.pointerCurrentRaycast.gameObject.name;
        //Debug.Log(ingredientName);
        if (gOrders.rawIngredientsUI.activeSelf)
        {
            //This is the preparation process from raw to cooked
            switch (ingredientName)
            {
                case "Rice(Clone)":
                    //Make the onigiri picture full opaque
                    gOrders.cookedContents[0].GetComponent<Image>().color = alphaFull;
                    //Increment of 1 the number of cooked onigiri
                    if (int.Parse(gOrders.cookedContents[1].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                        gOrders.cookedContents[1].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[1].GetComponent<Text>().text) + 1).ToString();
                        FindObjectOfType<AudioManager>().Play("BoilingSound");
                    }
                    break;


                case "RawSalmon(Clone)":
                    gOrders.cookedContents[2].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[3].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    gOrders.cookedContents[3].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[3].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("FryingSound");
                    }
                    break;

                case "RawChicken(Clone)":
                    gOrders.cookedContents[4].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[5].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    gOrders.cookedContents[5].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[5].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("FryingSound");
                    }
                    break;

                case "Pork(Clone)":
                    gOrders.cookedContents[6].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[7].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    
                    gOrders.cookedContents[7].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[7].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("FryingSound");
                    }
                    break;

                case "Egg(Clone)":
                    gOrders.cookedContents[8].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[9].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    
                    gOrders.cookedContents[9].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[9].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("BoilingSound");
                    }
                    break;

                case "RawSteak(Clone)":
                    gOrders.cookedContents[10].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[11].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    gOrders.cookedContents[11].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[11].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("FryingSound");
                    }
                    break;


                case "RawCarrot(Clone)":
                    gOrders.cookedContents[12].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[13].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    
                    gOrders.cookedContents[13].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[13].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("ChoppingSound");
                    }
                    break;

                case "RawRaddish(Clone)":
                    gOrders.cookedContents[14].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[15].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    
                    gOrders.cookedContents[15].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[15].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("ChoppingSound");
                    }
                    break;
                
                case "RawCherryTomato(Clone)":
                    gOrders.cookedContents[16].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[17].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    
                    gOrders.cookedContents[17].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[17].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("ChoppingSound");
                    }
                    break;

                case "RawBellPepper(Clone)":
                    gOrders.cookedContents[18].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[19].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    
                    gOrders.cookedContents[19].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[19].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("ChoppingSound");
                    }
                    break;

                case "RawBroccoli(Clone)":
                    gOrders.cookedContents[20].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[21].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    
                    gOrders.cookedContents[21].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[21].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("BoilingSound");
                    }
                    break;


                case "RawAsparagus(Clone)":
                    gOrders.cookedContents[22].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[23].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    
                    gOrders.cookedContents[23].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[23].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("BoilingSound");
                    }
                    break;

                case "RawEdamame(Clone)":
                    gOrders.cookedContents[24].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[25].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    gOrders.cookedContents[25].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[25].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("BoilingSound");
                    }
                    break;

                case "Lettuce(Clone)":
                    gOrders.cookedContents[26].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[27].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    gOrders.cookedContents[27].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[27].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("ChoppingSound");
                    }
                    break;

                case "RawOrange(Clone)":
                    gOrders.cookedContents[28].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[29].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    gOrders.cookedContents[29].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[29].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("ChoppingSound");
                    }
                    break;

                case "RawSweetPotato(Clone)":
                    gOrders.cookedContents[30].GetComponent<Image>().color = alphaFull;
                    if (int.Parse(gOrders.cookedContents[31].GetComponent<Text>().text) == 3)
                    {
                        FindObjectOfType<AudioManager>().Play("OrderWrongSFX");
                    }
                    else
                    {
                    //gOrders.currentPlayerOrder[3] = ingredientName.Substring(0, ingredientName.IndexOf("("));
                    gOrders.cookedContents[31].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[31].GetComponent<Text>().text) + 1).ToString();
                    FindObjectOfType<AudioManager>().Play("FryingSound");
                    }
                    break;
            }

            /*
            if (ingredientName.Contains("Rice"))
            {
                gOrders.currentPlayerOrder[0] = ingredientName;
                gOrders.cookedContents[0].GetComponent<Image>().color = alphaFull;
                gOrders.cookedContents[1].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[1].GetComponent<Text>().text) + 1).ToString();
            }
            else if ((ingredientName.Contains("RawSalmon") || ingredientName.Contains("RawChicken") || ingredientName.Contains("Pork") || ingredientName.Contains("Egg") || ingredientName.Contains("RawSteak")))
            {
                gOrders.currentPlayerOrder[1] = ingredientName;
                gOrders.cookedContents[2].GetComponent<Image>().color = alphaFull;
                gOrders.cookedContents[3].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[3].GetComponent<Text>().text) + 1).ToString();
            }
            else if ((ingredientName.Contains("RawCarrot") || ingredientName.Contains("RawRaddish") || ingredientName.Contains("RawCherryTomato") || ingredientName.Contains("RawBellPepper") || ingredientName.Contains("RawBroccoli")))
            {
                gOrders.currentPlayerOrder[2] = ingredientName;
                gOrders.cookedContents[4].GetComponent<Image>().color = alphaFull;
                gOrders.cookedContents[5].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[5].GetComponent<Text>().text) + 1).ToString();
            }
            else if ((ingredientName.Contains("RawAsparagus") || ingredientName.Contains("RawEdamame") || ingredientName.Contains("Lettuce") || ingredientName.Contains("RawOrange") || ingredientName.Contains("RawSweetPotato")))
            {
                //gOrders.currentPlayerOrder[3] = ingredientName.Substring(0, ingredientName.IndexOf("("));
                gOrders.currentPlayerOrder[3] = ingredientName;
                gOrders.cookedContents[6].GetComponent<Image>().color = alphaFull;
                gOrders.cookedContents[7].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[7].GetComponent<Text>().text) + 1).ToString();
            }
            */
        }
        else if (gOrders.cookedIngredientsUI.activeSelf && !bentoOrder.GetComponent<Text>().text.Contains("---")) //if the cooked ingredient UI is active and the current bento has an order active
        {
            FindObjectOfType<AudioManager>().Play("Selection");
            if (ingredientName.Contains("Onigiri") && int.Parse(gOrders.cookedContents[1].GetComponent<Text>().text) > 0)
            {
                //Decrement of 1 the number of onigiri
                gOrders.cookedContents[1].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[1].GetComponent<Text>().text) - 1).ToString();
                //if the number of onigiri reach 0 after the previous line of code 
                if (int.Parse(gOrders.cookedContents[1].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(0).GetComponent<Image>().color = alphaHalf;
                //change the sprite of the carb part of the bento and crank the opacity to max to be able to see it
                bentoUI.transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(0).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[0] = ingredientName;
            }
            
            else if (ingredientName.Contains("GrilledSalmon") && int.Parse(gOrders.cookedContents[3].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[3].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[3].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[3].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(2).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(1).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[1] = ingredientName;
            }
            else if (ingredientName.Contains("FriedChicken") && int.Parse(gOrders.cookedContents[5].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[5].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[5].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[5].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(4).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(1).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[1] = ingredientName;
            }
            else if (ingredientName.Contains("Tonkatsu") && int.Parse(gOrders.cookedContents[7].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[7].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[7].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[7].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(6).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(1).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[1] = ingredientName;
            }
            else if (ingredientName.Contains("BoiledEgg") && int.Parse(gOrders.cookedContents[9].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[9].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[9].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[9].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(8).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(1).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[1] = ingredientName;
            }
            else if (ingredientName.Contains("Steak") && int.Parse(gOrders.cookedContents[11].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[11].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[11].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[11].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(10).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(1).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[1] = ingredientName;
            }

            else if (ingredientName.Contains("Carrot") && int.Parse(gOrders.cookedContents[13].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[13].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[13].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[13].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(12).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(2).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[2] = ingredientName;
            }
            else if (ingredientName.Contains("Raddish") && int.Parse(gOrders.cookedContents[15].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[15].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[15].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[15].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(14).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(2).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[2] = ingredientName;
            }
            else if (ingredientName.Contains("CherryTomato") && int.Parse(gOrders.cookedContents[17].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[17].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[17].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[17].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(16).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(2).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[2] = ingredientName;
            }
            else if (ingredientName.Contains("BellPepper") && int.Parse(gOrders.cookedContents[19].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[19].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[19].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[19].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(18).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(2).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[2] = ingredientName;
            }
            else if (ingredientName.Contains("Broccoli") && int.Parse(gOrders.cookedContents[21].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[21].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[21].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[21].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(20).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(2).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[2] = ingredientName;
            }

            else if (ingredientName.Contains("Asparagus") && int.Parse(gOrders.cookedContents[23].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[23].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[23].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[23].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(22).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(3).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[3] = ingredientName;
            }
            else if (ingredientName.Contains("Edamame") && int.Parse(gOrders.cookedContents[25].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[25].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[25].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[25].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(24).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(3).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[3] = ingredientName;
            }
            else if (ingredientName.Contains("Salad") && int.Parse(gOrders.cookedContents[27].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[27].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[27].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[27].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(26).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(3).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[3] = ingredientName;
            }
            else if (ingredientName.Contains("Orange") && int.Parse(gOrders.cookedContents[29].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[29].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[29].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[29].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(28).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(3).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[3] = ingredientName;
            }
            else if (ingredientName.Contains("SweetPotato") && int.Parse(gOrders.cookedContents[31].GetComponent<Text>().text) > 0)
            {
                gOrders.cookedContents[31].GetComponent<Text>().text = (int.Parse(gOrders.cookedContents[31].GetComponent<Text>().text) - 1).ToString();
                if (int.Parse(gOrders.cookedContents[31].GetComponent<Text>().text) == 0) gOrders.cookedCont.transform.GetChild(30).GetComponent<Image>().color = alphaHalf;
                bentoUI.transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/"+ingredientName);
                bentoUI.transform.GetChild(3).GetComponent<Image>().color = alphaFull;
                gOrders.currentPlayerOrder[3] = ingredientName;
            }
        }
    }
}
