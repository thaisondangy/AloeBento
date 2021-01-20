using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        animator = this.GetComponent<Animator>();
        animator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && gameObject.activeSelf == true)
        {
            EndCredit();
        }
    }

    public void EndCredit(){
        gameObject.SetActive(false);
        animator.enabled = false;
    }
}
