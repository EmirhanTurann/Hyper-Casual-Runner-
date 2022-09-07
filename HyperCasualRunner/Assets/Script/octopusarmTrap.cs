using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class octopusarmTrap : MonoBehaviour
{
    public Animator anim;
    public GameObject portalmakerBig;
    public GameObject partical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim=GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag== "octopusarmstrap_Triger")
        {
           
            anim.SetBool("start",true);
        }

        if (col.gameObject.tag == "Player")
        {
             anim.SetBool("start", true);
            partical.gameObject.SetActive(true);
            if (portalmakerBig.gameObject.transform.localScale.x > 0)
            {
                portalmakerBig.gameObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            }
        }
    }
}
