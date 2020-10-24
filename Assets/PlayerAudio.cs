using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerAudio : MonoBehaviour
{
    public AudioClip splashSound;

    public AudioSource audioS;

    public AudioMixerSnapshot idleSnapshot;
    public AudioMixerSnapshot auxInSnapshot;
    public AudioMixerSnapshot ambIdleSnapshot;
    public AudioMixerSnapshot ambInSnapshot;

    public LayerMask enemyMask;

    bool enemyNear;
   

    private void Update()
    {
        RaycastHit[] hits = Physics.SphereCastAll(transform.position, 5f, transform.forward, 0f, enemyMask);


        if (hits.Length > 0)
        {
            enemyNear = true;
        }
        else
        {
            enemyNear = false;
        }
        if (!AudioManager.manager.eventRunning)
        {
            if (enemyNear)
            {
                if (!AudioManager.manager.auxIn)
                {
                    auxInSnapshot.TransitionTo(0.5f);
                    AudioManager.manager.currentAudioMixerSnapshot = auxInSnapshot;
                    AudioManager.manager.auxIn = true;

                }
                else
                {
                    if (AudioManager.manager.currentAudioMixerSnapshot == AudioManager.manager.eventSnap)
                    {
                        auxInSnapshot.TransitionTo(0.5f);
                        AudioManager.manager.currentAudioMixerSnapshot = auxInSnapshot;
                        AudioManager.manager.auxIn = true;
                    }
                }
            }
            else
            {
                if (AudioManager.manager.auxIn)
                {
                    idleSnapshot.TransitionTo(0.5f);
                    AudioManager.manager.currentAudioMixerSnapshot = idleSnapshot;

                    AudioManager.manager.auxIn = false;
                }
                else
                {
                    if (AudioManager.manager.currentAudioMixerSnapshot == AudioManager.manager.eventSnap)
                    {
                        idleSnapshot.TransitionTo(0.5f);
                        AudioManager.manager.currentAudioMixerSnapshot = idleSnapshot;

                        AudioManager.manager.auxIn = false;
                    }
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            audioS.PlayOneShot(splashSound);
        }
        if (other.CompareTag("Enemy Zone"))
        {
            auxInSnapshot.TransitionTo(0.5f);
        }
        if (other.CompareTag("Ambience"))
        {
            ambInSnapshot.TransitionTo(0.5f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            audioS.PlayOneShot(splashSound);
        }
        if (other.CompareTag("Enemy Zone"))
        {
            idleSnapshot.TransitionTo(0.5f);
        }
        if (other.CompareTag("Ambience"))
        {
            ambIdleSnapshot.TransitionTo(0.5f);
        }
    }
}
