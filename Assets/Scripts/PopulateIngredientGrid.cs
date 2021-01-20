using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateIngredientGrid : MonoBehaviour
{
    public GameObject[] ingredients;
    // Start is called before the first frame update
    void Start()
    {
        Populate();
    }

    void Populate(){
        for (int i = 0; i < ingredients.Length; i++)
        {   
            Instantiate(ingredients[i], transform);
        }
    }
}
