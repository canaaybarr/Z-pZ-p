using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yonetici : MonoBehaviour
{
    public Text skor;
    public bool oyundurdumu = false;
    public static float skorsayisi;
    public void oyundurdur()
    {
        if(oyundurdumu == false)
        {
            Time.timeScale = 0f;
            oyundurdumu = true;
        }
        else
        {
            Time.timeScale = 1f;
            oyundurdumu = false;
        }
    void Update() {
        skor.text = skorsayisi.ToString();
    }
    
        
    }
    
}
