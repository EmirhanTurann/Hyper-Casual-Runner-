using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class enemy_Bar : MonoBehaviour
{
    public int enemyCount;
    public Slider enemySlider;
    float maxCount=20;
    GameObject a;
   public float sayac;
    public List<GameObject> enemys = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var objects = GameObject.FindGameObjectsWithTag("Enemy");
        var objectCount = objects.Length;
        enemyCount = objectCount;
        enemySlider.value = objectCount;
        Enemy script = gameObject.GetComponent<Enemy>();
        script = FindObjectOfType<Enemy>();
        if (enemyCount<=5)
        {
            sayac += Time.deltaTime * 1f;
  int spawnNumber = 0;
            if (sayac>2)
            {

            
            for (int i = 0; i < enemys.Count; i++)
        {
               

                

            if (enemys[i].activeSelf)
            {
                Debug.Log(enemys[i].gameObject.name);
            }
            else
            {
                spawnNumber++;
                        if (spawnNumber <= Random.Range(2,5))
                {
                   
                        enemys[i].SetActive(true);
                       
                            sayac =0;
                }




            
        }
        }
            }
      }
    }
    
   

    }
