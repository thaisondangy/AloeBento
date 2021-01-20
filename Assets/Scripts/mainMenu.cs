using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{

    public Animator animator;
    public GameObject cover;

    public GameObject instructionsImage;
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            instructionsImage.SetActive(false);
        }
    }

    public void Instructions() {
        instructionsImage.SetActive(true);

    }

    public void Return() {
        instructionsImage.SetActive(false);

    }

    
    public void ClickCredit(){
        cover.SetActive(true);
        animator.enabled = true;
    }

}
