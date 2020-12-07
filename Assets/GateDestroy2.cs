using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateDestroy2 : MonoBehaviour
{
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Cannon"))
        {
            this.gameObject.GetComponent<Animation>().Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
