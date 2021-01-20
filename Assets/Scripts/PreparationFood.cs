using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreparationFood : MonoBehaviour
{
    private Image image;
    private Animator anim;
    private bool addedToBento;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
        image = this.GetComponent<Image>();
        addedToBento = false;
        anim.enabled = false;
        var tempColor = image.color;
            tempColor.a = 0.50f;
            image.color = tempColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (image.sprite != null)
        {
            StartCoroutine(PreparationTime());
            if (Input.GetMouseButtonDown(0) && image.fillAmount == 1f)
            {
                anim.Play("ZoomAnimation", 0, 0);
                addedToBento = true;
                gameObject.GetComponent<SplineController>().FollowSpline();
            }
        }
    }

    IEnumerator PreparationTime(){
        image.fillAmount += Time.deltaTime/10;
        anim.enabled = false;
        
        if (image.fillAmount == 1f && !addedToBento)
        {
            var tempColor = image.color;
            tempColor.a = 1f;
            image.color = tempColor;
            anim.enabled = true;
            yield return null;
        }
    }
}
