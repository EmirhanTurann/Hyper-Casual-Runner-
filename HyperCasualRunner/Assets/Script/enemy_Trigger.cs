using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Trigger : MonoBehaviour
{
    int b;
    public bool speedup=false;
    
    public List<GameObject> enemys = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
       
        if (col.gameObject.tag =="Enemy")
        {
            speedup = true;
            //enemys[5].transform.position = Vector3.Lerp(transform.position, new Vector3(enemys[5].transform.position.x, enemys[5].transform.position.y, enemys[5].transform.position.z + 2), Time.deltaTime * 2);

            Debug.Log("asd");
        }


    }
}
