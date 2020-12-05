using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEvent : MonoBehaviour
{
    public Transform particle;
    public Transform generator;
    public Transform duo;

    void Start()
    {
        particle.GetComponent<ParticleSystem>().enableEmission = false;
        generator.GetComponent<ParticleSystem>().enableEmission = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            particle.GetComponent<ParticleSystem> ().enableEmission = true;

        }
    }

    void Update()
    {
        if (particle.GetComponent<ParticleSystem>().enableEmission == true)
        {
            if (duo.GetComponent<ParticleSystem>().enableEmission == true)
            {
                generator.GetComponent<ParticleSystem>().enableEmission = true;
            }
        }
    }

}
