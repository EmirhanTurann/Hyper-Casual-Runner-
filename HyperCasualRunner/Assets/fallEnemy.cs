using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallEnemy : MonoBehaviour
{
    public float speed = 10;
    bool falling;
    float sayac;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //  this.transform.Translate(0, (-speed * Time.deltaTime), 0);
        this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(this.transform.position.x,  -5, this.transform.position.z-1), Time.deltaTime*0.8f);

        if(this.transform.position.y<-1)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(this.transform.position.x, 0, this.transform.position.z - 1), 1);
            this.gameObject.SetActive(false);
        }
    }
  }
