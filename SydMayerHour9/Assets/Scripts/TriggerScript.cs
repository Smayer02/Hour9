using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Returns a string of what collider was entered
    string Compare()
    {
        if(this.CompareTag("LTrigger"))
            return("Left");
        else if (this.CompareTag("RTrigger"))
            return("Right");
        else
            return("N/A");
    }

    void OnTriggerEnter (Collider other)
    {
        print(other.gameObject.name + " has entered the " + Compare() + " trigger");
    }

    void OnTriggerStay (Collider other)
    {
        print(other.gameObject.name + " is in the " + Compare() + " trigger");
    }

    void OnTriggerExit (Collider other)
    {
        print(other.gameObject.name + " has left the " + Compare() + " trigger");
    }

}
