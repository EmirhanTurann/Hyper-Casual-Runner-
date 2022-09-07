using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickman_Move : MonoBehaviour
{

    public Camera mainCamera;
    public float speed = 10f;
    public GameObject portalMaker;
    public int portalmakerHealth=0;
    public GameObject portalmakerBig;
    public GameObject portalmakerMiddle;
    public GameObject portalmakerSmall;
    public Animator anim;
    public GameObject deathman;
    public float sayac;
    public float sayac2;
    public GameObject flyman;
    bool finish=false;
    public GameObject man;
    public GameObject cloak;
    public bool death=false;
    public GameObject tapto_play;
    public GameObject gameOver;
    bool stopcollectible = false;
    public GameObject enemy;
    public GameObject portalcount;

    // Start is called before the first frame update
    void Start()
    {
       stopGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (stopcollectible==true)
        {
            spawnpointHareket script3 = gameObject.GetComponent<spawnpointHareket>();
            script3 = FindObjectOfType<spawnpointHareket>();
            script3.sayac = 0;
        }
        if (death==true)
        {
            sayac2 += Time.deltaTime * 1f;
            if (sayac2 > 5)
            {
                gameOver.SetActive(true);
                sayac2 = 0;
            }
        }
        
        this.transform.Translate(0, 0, (speed * Time.deltaTime));
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, new Vector3(4.91f, 9.313f, transform.position.z - 20), Time.deltaTime * 3);
       

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase== TouchPhase.Began)
            {
                startGame();
            }
            

            if (touch.phase == TouchPhase.Moved)
            {
                if (death == false) { 
                    transform.position = Vector3.Lerp(transform.position, new Vector3(touch.position.x* 0.01f, 0, transform.position.z), Time.deltaTime *20);
                Debug.Log("Haraket ediyor");

                }
                
               
            }
        

        }

        sayac =+ 10 * Time.deltaTime;
    }

    public void stopGame() 
    {
        Time.timeScale = 0f;
        spawnpointHareket script = gameObject.GetComponent<spawnpointHareket>();
        script = FindObjectOfType<spawnpointHareket>();
        script.pause = true;
        tapto_play.gameObject.SetActive(true);
    }

    public void startGame()
    {
        Time.timeScale = 1f;
        spawnpointHareket script = gameObject.GetComponent<spawnpointHareket>();
        script = FindObjectOfType<spawnpointHareket>();
        script.pause = false;
        tapto_play.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Book")
        {
            if (portalmakerBig.gameObject.transform.localScale.x * 5 < 2.77)

            {
                
                portalmakerBig.gameObject.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            }

            
}


            if (col.gameObject.tag=="Saw")
            {
            if (portalmakerBig.gameObject.transform.localScale.x > 0)
            {
                portalmakerBig.gameObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            }
     
        }
        if (col.gameObject.tag=="Enemy")
        {
            Debug.Log("ÖLDÜNNNNNNN");
            speed = 0;
          
       
        }
        if (col.gameObject.tag == "trap" )
        {
            if (portalmakerBig.gameObject.transform.localScale.x>0)
            {
    portalmakerBig.gameObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            }
        }
      
        if (col.gameObject.tag == "finish")
        {
           
            man.gameObject.SetActive(false);
            portalmakerBig.gameObject.SetActive(false);
            portalmakerMiddle.gameObject.SetActive(false);
            portalmakerSmall.gameObject.SetActive(false);
            cloak.gameObject.SetActive(false);
            portalcount.gameObject.SetActive(false);
            flyman.SetActive(true);
            stopcollectible =true;
            this.GetComponent<door_Trigger>().enabled = false;




        }

        if (col.gameObject.tag == "fallTrigger")
        {
            gameOver.SetActive(true);
        }

    }
}
    
    
