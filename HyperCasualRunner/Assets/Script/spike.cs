using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike : MonoBehaviour
{
    public float sayac;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sayac += Time.deltaTime * 1f;

        if ( sayac>5)
        {
         
             Destroy(this.gameObject);
            sayac = 0;
        }
      
        this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 2f), 9f * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
       
    }
}
