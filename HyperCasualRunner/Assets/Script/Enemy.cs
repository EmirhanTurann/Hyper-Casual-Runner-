using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10;
    public float speed2 = 7;
    public GameObject Group1;
   
    public GameObject man;
    public GameObject portal;
    public bool open_portal = false;
    public bool speed_increase = false;
    enemy_Bar script;
    public GameObject deathTrigger;
    public GameObject spike;
    public bool fire;
    float sayac;
    

    // Update is called once per frame
    void Update()

    {
       
       

        enemy_Bar script = gameObject.GetComponent<enemy_Bar>();
        script = FindObjectOfType<enemy_Bar>();
        enemy_Trigger script2 = gameObject.GetComponent<enemy_Trigger>();
        script2 = FindObjectOfType<enemy_Trigger>();
        var objects = GameObject.FindGameObjectsWithTag("Enemy");
        var objectCount = objects.Length;
        int enemyCount = objectCount;

        if (script2.speedup==true)
        {

           
          speed_increase = true;
          transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, man.transform.position.z - speed2),1f*Time.deltaTime);
           
        }
        if (enemyCount <=10)
        {
          
           
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, man.transform.position.z -speed), 1f * Time.deltaTime);
          
        }





    }




}

