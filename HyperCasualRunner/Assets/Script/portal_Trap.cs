using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_Trap : MonoBehaviour
{
    public Collider enemyCollider;
    public GameObject fallEnemy;
    public float speed=1;
   
   

    

    private void OnTriggerEnter(Collider col)
    {
        death_Trigger script = gameObject.GetComponent<death_Trigger>();
        script = FindObjectOfType<death_Trigger>();
        if (col.gameObject.tag== "Enemy")
        {
           
          col.gameObject.SetActive(false);
          fallEnemy.SetActive(true);
           
         
       

            this.gameObject.SetActive(false);
            
 col.gameObject.transform.position = new Vector3(col.gameObject.transform.position.x, col.gameObject.transform.position.y, col.gameObject.transform.position.z-3);
           
           
         


        }
    }
}
