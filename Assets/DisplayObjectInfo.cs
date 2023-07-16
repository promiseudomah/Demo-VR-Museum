using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]

public class DisplayObjectInfo : MonoBehaviour
{
    CanvasGroup cg;
    Animator anim;

    void Start()
    {
        
        cg = GetComponent<CanvasGroup>();
        anim = GetComponent<Animator>();

        cg.alpha = 0;
    }

    void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag("Player")){

            Debug.Log("Player just Entered! ");
            cg.alpha = 0;

            anim.Play("FadeIn");
            
        }   
    }

    void OnTriggerExit(Collider other)
    {

        if(other.CompareTag("Player")){

            Debug.Log("Player just Entered! ");
            cg.alpha = 0;

            anim.Play("FadeOut");
        }   
    }
}
