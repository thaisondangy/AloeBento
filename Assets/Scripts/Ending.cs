using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public Animator animator;
    private GameObject backGround;
    private GameObject cover;
    private bool allowRollCredit, allowEndingEnd;
    // Start is called before the first frame update
    void Start()
    {
        AudioListener.pause = false;
        backGround = GameObject.Find("Background");
        cover = GameObject.Find("Cover");
        allowRollCredit = false;
        allowEndingEnd = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (allowRollCredit && Input.anyKeyDown)
        {
            animator.SetTrigger("allowRollCredit");
        }
        if (allowEndingEnd && Input.anyKeyDown)
        {
            SceneManager.LoadScene(0);
        }
        
    }

    public void AllowRollCredit(){
        allowRollCredit = true;
    }

    public void AllowEndingEnd(){
        Debug.Log("allowEnding");
        allowEndingEnd = true;
    }
}
