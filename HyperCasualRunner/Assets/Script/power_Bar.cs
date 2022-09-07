using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class power_Bar : MonoBehaviour
{
    public Slider powerSliderGreen;
    public Slider powerSliderOrange;
    public Slider powerSliderRed;
    public Slider BigpowerSliderOrange;
    public GameObject portalmaker;
   
    

    // Update is called once per frame
    void Update()
    {
        collect script = gameObject.GetComponent<collect>();
        script = FindObjectOfType<collect>();

      
        BigpowerSliderOrange.value = portalmaker.gameObject.transform.localScale.x*5;
     
        Debug.Log("portal boyut"+portalmaker.gameObject.transform.localScale.x*5);

        if (script.book<=5&&script.book>=1)
        {
            powerSliderGreen.value=script.book;
        }
        if (script.book <= 10 && script.book >= 6)
        {
            powerSliderOrange.value = script.book;
        }
        if (script.book <= 15 && script.book >= 7)
        {
            powerSliderRed.value = script.book;
        }
    }
}
