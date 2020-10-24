using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class WaterSfx : MonoBehaviour
{
    public AudioMixerSnapshot waterIdle;
    public AudioMixerSnapshot underwater;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            underwater.TransitionTo(0.5f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            waterIdle.TransitionTo(0.5f);
        }
    }
}