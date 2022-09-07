using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2_Spawnpoint : MonoBehaviour
{
    public float sayac;
    public GameObject door2;
    public GameObject man;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sayac++;
        if (sayac > Random.Range(300, 600))
        {
            GameObject gecici = Instantiate(door2);
            gecici.transform.position = this.transform.position;
            sayac = 0;
        }
        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, man.transform.position.z + 50), 1);

    }
}
