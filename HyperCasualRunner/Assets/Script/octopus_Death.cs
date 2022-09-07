using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class octopus_Death : MonoBehaviour
{
    public GameObject splitOctopus;
    public Animator octopusanim;
    public GameObject GameWin;
   public float sayac;
    bool win=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (win==true)
        {
           sayac += Time.deltaTime * 1f;
        }
       
        
    }
    private void OnTriggerEnter(Collider col)
    {


        if (col.gameObject.tag=="octopusSaw")
        {
            this.gameObject.SetActive(false);
            splitOctopus.gameObject.SetActive(true);
            win = true;
            if (sayac>1)
            {
                GameWin.SetActive(true) ;
            }
        }
    }

}
