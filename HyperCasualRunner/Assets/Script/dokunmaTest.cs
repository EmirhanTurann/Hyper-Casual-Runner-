using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dokunmaTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch parmak = Input.GetTouch(0);
            if (parmak.phase == TouchPhase.Began)
            {
                Debug.Log("Dokundu ");
            }
            if (parmak.phase == TouchPhase.Stationary)
            {
                Debug.Log("Dokunuyor ");
            }
            if (parmak.phase == TouchPhase.Moved)
            {
                Debug.Log("sürekleniyor ");
            }
            if (parmak.phase == TouchPhase.Ended)
            {
                Debug.Log("dokunma bitti ");
            }
        }
    }
}
