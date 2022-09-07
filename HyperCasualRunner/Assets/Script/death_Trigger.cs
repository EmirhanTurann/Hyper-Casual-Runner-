using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death_Trigger : MonoBehaviour
{
    public Animator enemyanim;
    public GameObject spike;
    public float sayac;
    public Collider enemyCollider;

    // Start is called before the first frame update
    void Start()
    {
        enemyanim = GetComponent<Animator>();
        enemyCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        stickman_Move script = gameObject.GetComponent<stickman_Move>();
        script = FindObjectOfType<stickman_Move>();
        death_Trigger script2 = gameObject.GetComponent<death_Trigger>();
        script2 = FindObjectOfType<death_Trigger>();
       if (script.death==true)
        {
          

        }
       
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "deathTrigger")
        {

            enemyanim.SetBool("spell", true);
            spike.SetActive(true);
            col.gameObject.SetActive(false);
            
          
 spike.transform.position= Vector3.Lerp(spike.transform.position, new Vector3(spike.transform.position.x, spike.transform.position.y, spike.transform.position.z+2f ), 12f * Time.deltaTime);

            stickman_Move script = gameObject.GetComponent<stickman_Move>();
            script = FindObjectOfType<stickman_Move>();
            script.death = true;


        }
    }
}
