using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public float soundVolume = 0.5f;
    private AudioSource audioSource;

    public AudioClip jumpSound;
    public AudioClip dashSound;
    public AudioClip deathSound;
    public AudioClip collectArtifactSound;
    public AudioClip portalSound;
    


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        audioSource.volume = soundVolume;
    }

    public void PlayOneShot(string shotName)
    {
        if(shotName == "jump") { 
        
            audioSource.PlayOneShot(jumpSound);
        }
        else if (shotName == "death")
        {
            audioSource.PlayOneShot(deathSound);
        }
        else if (shotName == "dash")
        {
            audioSource.PlayOneShot(dashSound);
        }
        else if (shotName == "collect")
        {
            audioSource.PlayOneShot(collectArtifactSound);
        }else if (shotName == "portal")
        {
            audioSource.PlayOneShot(portalSound);

        }
        else { Debug.Log("No audio clip to play"); }

    }


}
