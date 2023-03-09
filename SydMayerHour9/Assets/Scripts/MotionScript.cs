using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");
        if (hVal > 0)
            transform.Translate(.05f, 0f, 0f);
        else if (hVal < 0)
            transform.Translate(-.05f, 0f, 0f);
        
        if (vVal > 0)
            transform.Translate(0f, .05f, 0f);
        else if (vVal < 0)
            transform.Translate(0f, -0.05f, 0f);
    }
}
