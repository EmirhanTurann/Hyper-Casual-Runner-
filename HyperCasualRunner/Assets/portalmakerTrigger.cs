using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalmakerTrigger : MonoBehaviour
{
    bool portalopen=false;
    bool portalclose=false;
    
    float sayac;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Debug.Log("saniye="+sayac);
        door_Trigger script = gameObject.GetComponent<door_Trigger>();
        script = FindObjectOfType<door_Trigger>();
       
        if (portalopen==true)
        {
            if (script.portalCount>0)
            {
 for (int i = 1; i <= script.portalCount; i++)
           {
          
            script.traps[i-1].SetActive(true);
       

           }
            }

            portalopen = false;
        }
        
        
        if (portalclose==true)
        {
            sayac += Time.deltaTime * 1;
            if (sayac>3)
            {

                script.traps[0].SetActive(false);
                script.traps[1].SetActive(false);
                script.traps[2].SetActive(false);
                script.traps[3].SetActive(false);
                script.traps[4].SetActive(false);
                script.traps[5].SetActive(false);
                script.traps[6].SetActive(false);
                script.traps[7].SetActive(false);
                script.traps[8].SetActive(false);
                script.traps[9].SetActive(false);
                sayac = 0;
                portalclose = false;
            }
        } 
       
    }

    private void OnTriggerEnter(Collider col)
    {
        door_Trigger script = gameObject.GetComponent<door_Trigger>();
        script = FindObjectOfType<door_Trigger>();
       
        if (col.gameObject.tag == "Player")
        {
            portalopen = true;
            script.portals.gameObject.transform.position = new Vector3(script.portals.transform.position.x, script.portals.transform.position.y, col.gameObject.transform.position.z + 2);
          
          
            

        }
    }
    private void OnTriggerExit(Collider col)
    {
        door_Trigger script = gameObject.GetComponent<door_Trigger>();
        script = FindObjectOfType<door_Trigger>();
        
        if (col.gameObject.tag == "Player") 
        {
            script.portalCount = 0;

            portalclose = true;


        }
            
    }

    }
