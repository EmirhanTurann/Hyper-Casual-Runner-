using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapSpawn : MonoBehaviour
{ 
    GameObject gecici;
    public float sayac;

    public GameObject spike;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        sayac += Time.deltaTime * 1f;
        
        if (sayac > 4)
        {
             gecici = Instantiate(spike);
            gecici.transform.position = this.transform.position;
            sayac = 0;
        }
        
    }
}
