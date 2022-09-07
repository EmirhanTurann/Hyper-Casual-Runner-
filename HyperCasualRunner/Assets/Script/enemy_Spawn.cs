using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class enemy_Spawn : MonoBehaviour
{
 
    public GameObject manFront;
    public GameObject manMiddle;
    public GameObject manBack;

    public List<GameObject> players = new List<GameObject>();
    public int random;
    public int min=0;
    public int max=10;
    public int xposition;
    public int Distance =4;
    public List<int> intlist = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
       

       
            
       
       

    }
   public void spawn(int a) 
    {


       
       

        for (int i = 1; i <= a; i++)
        {
        
        
             
           
            GameObject gecici = Instantiate(manFront, new Vector2(xposition,0), Quaternion.identity, transform);
            xposition += Distance;
             
             random = Random.Range(0, 10);

            gecici.transform.position = new Vector3(random , 0, 0);
           




        }

    }
    // Update is called once per frame
    void Update()
    {
     

    }
    public Vector3 PlayerPosition() 
    {
    Vector3 pos = Random.insideUnitSphere * 1;


    Vector3 newPos = transform.position + pos;
    newPos.y = 0.5f;
        return newPos;
    }
    

}
