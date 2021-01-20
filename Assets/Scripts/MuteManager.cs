using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteManager : MonoBehaviour
{

    private Image soundIcons;
    
    private bool isMuted;


    void Start()
    {
        soundIcons = GameObject.Find("MuteButton").GetComponent<Image>();
        isMuted = false;
    }

    public void MutePressed() {
        FindObjectOfType<AudioManager>().Play("Selection");
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        
        if (isMuted) {
            soundIcons.sprite = Resources.Load<Sprite>("Sprites/Mute");
        }
        else{
            soundIcons.sprite = Resources.Load<Sprite>("Sprites/Audio");
        }
    }

    
}
