using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saw_Move : MonoBehaviour
{
    public Transform from;
    public GameObject partical;
    public Animator anim;
 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      

        if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("SawAnimation"))
        {
            anim.SetBool("saw",true);
            
            
        }
     if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("SawAnimation 0"))
            {
                anim.SetBool("saw", false);
            }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag=="Player")
        {
          partical.gameObject.SetActive(true);
        }
        
    }
}