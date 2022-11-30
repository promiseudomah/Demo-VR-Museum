using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamps : MonoBehaviour
{
    public PickStampsManager psm;

    private void Start()
    {
        gameObject.SetActive(true);
    }   
    public void CollectStamp(){

        psm.SetStamps();
        Invoke("OnDestroy", 0.25f);
        
    }

    void OnDestroy(){
        gameObject.SetActive(false);
    }
 
  
}

