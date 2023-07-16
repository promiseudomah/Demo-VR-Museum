using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaptorSoundEffects : MonoBehaviour
{
    //Variables

    AudioSource audioSource;


    //Sound Variants

    public AudioClip[] growlClips;

    public AudioClip[] sniffClips;

    public AudioClip[] yelpClips;

    public AudioClip[] barkClips;

    public AudioClip[] roarClips;

    public AudioClip[] screechClips;

    public AudioClip[] callClips;

    public AudioClip[] deathClips;


    //Gather variables

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //Growl Sounds (Random)

    public void Growl()
    {
        int Index = Random.Range(0, growlClips.Length);

        AudioClip clip = growlClips[Index];
        audioSource.PlayOneShot(clip);
    }

    //Sniff Sounds (Random)

    public void Sniff()
    {
        int Index = Random.Range(0, sniffClips.Length);

        AudioClip clip = sniffClips[Index];
        audioSource.PlayOneShot(clip);
    }

    //Yelp Sounds (Random)

    public void Yelp()
    {
        int Index = Random.Range(0, yelpClips.Length);

        AudioClip clip = yelpClips[Index];
        audioSource.PlayOneShot(clip);
    }

    //Bark Sounds (Random)

    public void Bark()
    {
        int Index = Random.Range(0, barkClips.Length);

        AudioClip clip = barkClips[Index];
        audioSource.PlayOneShot(clip);
    }

    //Roar Sounds (Random)

    public void Roar()
    {
        int Index = Random.Range(0, roarClips.Length);

        AudioClip clip = roarClips[Index];
        audioSource.PlayOneShot(clip);
    }

    //Screech Sounds (Random)

    public void Screech()
    {
        int Index = Random.Range(0, screechClips.Length);

        AudioClip clip = screechClips[Index];
        audioSource.PlayOneShot(clip);
    }

    //Call Sounds (Random)

    public void Call()
    {
        int Index = Random.Range(0, callClips.Length);

        AudioClip clip = callClips[Index];
        audioSource.PlayOneShot(clip);
    }

    //Call Sounds (Ordered)

    public void Call1()
    {
        AudioClip clip = callClips[0];
        audioSource.PlayOneShot(clip);
    }
    public void Call2()
    {
        AudioClip clip = callClips[1];
        audioSource.PlayOneShot(clip);
    }
    public void Call3()
    {
        AudioClip clip = callClips[2];
        audioSource.PlayOneShot(clip);
    }

    //Death Sounds (Random)

    public void Death()
    {
        int Index = Random.Range(0, deathClips.Length);

        AudioClip clip = deathClips[Index];
        audioSource.PlayOneShot(clip);
    }
}
