using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_Trigger : MonoBehaviour
{

    public GameObject portal;
   
    public GameObject deathTrigger;
    public int doorNumber;
    public int spawnNumber;
    public GameObject armtrigger;
    public float sayac;
    bool sayacStart;
   public int portalCount;
    public GameObject portalcountText;
    public List<GameObject> traps = new List<GameObject>();
    public GameObject portals;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TextMesh textObject = GameObject.Find("portalCount").GetComponent<TextMesh>();
        textObject.text = portalCount.ToString();
  
       
        
        if (portalCount<0)
        {
            portalCount = 0;
        }
        if (sayacStart==true)
        {
            sayac += 2f * Time.deltaTime;
        }
        if (sayac > 2f)
        {
            armtrigger.SetActive(true);
            sayacStart = false;
            sayac = 0;
        }
       
    }
    private void OnTriggerEnter(Collider col)
    {
        Portal script = gameObject.GetComponent<Portal>();
        script = FindObjectOfType<Portal>();
      
        if (col.gameObject.tag == "portalmakerTrigger")
        {

            if (portalCount==3)
            {
                portals.gameObject.transform.position = new Vector3(portals.transform.position.x, portals.transform.position.y, col.gameObject.transform.position.z + 2);
            }
        
        }
            if (col.gameObject.tag == "Door+2")
        {
            portalCount += 2;
            
             armtrigger.SetActive(false);
              sayacStart = true;


        }
         if (col.gameObject.tag == "Door+5" )
         {

          
            portalCount += 5;
            



              armtrigger.SetActive(false);
             sayacStart = true;


        }




        if (col.gameObject.tag == "Door+3")
        {

            portalCount += 3;

           
               armtrigger.SetActive(false);
               sayacStart = true;


        }
        if (col.gameObject.tag == "Door-2")
        {

            portalCount -= 2;
            armtrigger.SetActive(false);
            sayacStart = true;
  

        }

        if (col.gameObject.tag == "Door-1")
        {
            armtrigger.SetActive(false);
            sayacStart = true;

            portalCount -= 1;
           

        }
        if (col.gameObject.tag == "Door-3")
        {
            armtrigger.SetActive(false);
            sayacStart = true;

            portalCount -= 3;
            

        }
        if (col.gameObject.tag == "Door-5")
        {
            armtrigger.SetActive(false);
            sayacStart = true;
           
           
            portalCount -= 5;
    
        }
        if (col.gameObject.tag == "Doorx2")
        {

            armtrigger.SetActive(false);
            sayacStart = true;

            portalCount *= 2;
        }
        if (col.gameObject.tag == "Door+10")
        {

            armtrigger.SetActive(false);
            sayacStart = true;

            portalCount += 10;
        }
        if (col.gameObject.tag == "Door-7")
        {

            armtrigger.SetActive(false);
            sayacStart = true;

            portalCount -= 7;
        }

    }
  

    }
