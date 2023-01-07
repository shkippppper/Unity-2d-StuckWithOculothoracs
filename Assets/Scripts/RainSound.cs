using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSound : MonoBehaviour
{
    public GameObject musicManagment;
    private MusicManager musicManager;
    private AudioSource audioSource;

    private void Awake()
    {
        musicManager = musicManagment.GetComponent<MusicManager>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        audioSource.volume = musicManager.musicVolume*1.5f;
    }
}
