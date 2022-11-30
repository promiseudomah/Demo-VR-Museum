using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//giddy wrote this

public class PickStampsManager : MonoBehaviour
{
    public GameObject[] stampsCount;
    public int stampsCollected = 0;
    public TextMeshProUGUI stampsCountText;

    void Start(){
        string x = stampsCollected.ToString();
        string y = stampsCount.Length.ToString();

        stampsCountText.text = x + "/" + y + " stamps collected"; 
                                //* 3/6 stamps collected
    }
    public void SetStamps(){
         
        stampsCollected += 1;

        string x = stampsCollected.ToString();
        string y = stampsCount.Length.ToString();

        stampsCountText.text = x + "/" + y + " stamps collected"; 
                                //* 3/6 stamps collected

    }
}
