using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{ 

    public int enemyCount=0;
    Vector3 c;
    // Start is called before the first frame update
    door_Trigger script;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
 door_Trigger script = gameObject.GetComponent<door_Trigger>();
      
        if (col.gameObject.tag == "Enemy")
        {
             script = FindObjectOfType<door_Trigger>();
           
            enemyCount =enemyCount+1;
            col.gameObject.SetActive(false);
            

         
           
            
            
              if (enemyCount == script.doorNumber)
            {
                
                Destroy(this.gameObject);
                enemyCount = 0;
              
               
              
               

            }
            
          
           
          
           


        }

    }
}
