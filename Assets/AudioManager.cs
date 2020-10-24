using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager manager;

    private void Awake()
    {
        manager = this;
    }

    public AudioSource mainMusic;
    public AudioSource auxMusic;
    public AudioSource ambSound;
    public AudioSource ambTwoSound;


    public AudioSource eventMusic;

    public AudioMixerSnapshot eventSnap;
    public AudioMixerSnapshot idleSnapshot;

    public bool eventRunning;
    public bool auxIn;

    public AudioMixerSnapshot currentAudioMixerSnapshot;
    public IEnumerator PlayEventMusic()
    {
        eventRunning = true;
        eventSnap.TransitionTo(0.25f);
        currentAudioMixerSnapshot = eventSnap;
        yield return new WaitForSeconds(0.3f);
        eventMusic.Play();
        while (eventMusic.isPlaying)
        {

            yield return null;
        }
        eventRunning = false;
        //   idleSnapshot.TransitionTo(0.5f);
        yield break;
    }

}