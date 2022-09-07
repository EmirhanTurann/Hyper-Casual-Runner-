using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpointHareket : MonoBehaviour
{


    public float sayac;

    public Transform spawnNoktasi;
    public GameObject book;
    public GameObject man;
    public bool pause=false;

   
    // Update is called once per frame
    void Update()
    {
     
        if (pause==true)
        {

        }
        else
        {
           sayac++;
        }
       
        if (sayac>100)
        {
            GameObject gecici = Instantiate(book);
            gecici.transform.position = this.transform.position;
            sayac = 0;
        }
            transform.position = Vector3.Lerp(transform.position, new Vector3(Random.Range(0.0f, 10.0f), book.transform.position.y, man.transform.position.z+8), 1);
        
    

    }
}
