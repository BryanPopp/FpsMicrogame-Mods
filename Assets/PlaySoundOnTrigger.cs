using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnTrigger : MonoBehaviour
{

    AudioSource source;

    BoxCollider soundTrigger;

    

    void Awake() {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<BoxCollider>();
        
    }


    void OnTriggerEnter() {
       
        source.Play();

    }
    
}
