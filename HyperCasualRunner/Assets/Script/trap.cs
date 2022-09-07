using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    public GameObject man;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(man.transform.position.x, man.transform.position.y, man.transform.position.z), 1);
    }

    private void OnTriggerEnter(Collider col)
    {
       
    }

}
