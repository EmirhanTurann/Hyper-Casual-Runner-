using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    public int book;
    public GameObject portalmakerBig;


    private void OnTriggerEnter(Collider col)
    {
       
        if (col.gameObject.tag=="Book")
        {
            Destroy(col.gameObject);
      
            book=book+1; 
         }   

  

    }
}
