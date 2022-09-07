using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saw_trigger : MonoBehaviour
{
    public GameObject saw;
    public Camera cam;
    public GameObject portalmaker;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Animator octopusanim;
    public Animator flymananim;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        power_Bar script = gameObject.GetComponent<power_Bar>();
        script = FindObjectOfType<power_Bar>();
         stickman_Move script2 = gameObject.GetComponent<stickman_Move>();
            script2 = FindObjectOfType<stickman_Move>();
      
        if (col.gameObject.tag == "flyman"&& script.BigpowerSliderOrange.value>=2.77f) 
        {
            saw.gameObject.SetActive(true);
        }
       
        if (script.BigpowerSliderOrange.value  < 2.77f && col.gameObject.tag == "flyman")
        {
           
            octopusanim.SetBool("win",true);
         
            flymananim.SetBool("death",true);
            
          
            script2.death = true;
           
        }


        if (col.gameObject.tag == "flyman")
        {
            
            cam.gameObject.SetActive(true);
        }
    }

}
