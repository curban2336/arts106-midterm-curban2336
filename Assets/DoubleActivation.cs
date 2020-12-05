using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleActivation : MonoBehaviour
{
    public Transform particle;
    public Transform duo;
    public Transform generator;
    // Start is called before the first frame update
    void Start()
    {
        generator.GetComponent<ParticleSystem>().enableEmission = false;

        if (particle.GetComponent<ParticleSystem>().enableEmission == true)
        {
            if (duo.GetComponent<ParticleSystem>().enableEmission == true)
            {
                generator.GetComponent<ParticleSystem>().enableEmission = true;
            }
        }
    }
}
