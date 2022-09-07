using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_Spawn : MonoBehaviour
{
    public float sayac;
    public GameObject door1;
    public GameObject man;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sayac++;

       
        
        if (sayac > Random.Range(400, 700))
        {
            GameObject gecici = Instantiate(door1);
            gecici.transform.position = this.transform.position;
            sayac = 0;
        }
            
        
        
        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, man.transform.position.z + 50), 1);
       
    }
}
