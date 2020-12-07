using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
{
    public Transform particle;

    void Start()
    {
        //particle.GetComponent<ParticleSystem>().enableEmission = false;
        particle.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //particle.GetComponent<ParticleSystem>().enableEmission = true;
            particle.gameObject.SetActive(true);

        }
    }
}
