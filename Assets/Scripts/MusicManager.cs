using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public float musicVolume = 0.5f;
    private AudioSource audioSource;

    public AudioClip mainMenuMusic;
    public AudioClip spawnMusic;
    public AudioClip firstLevelMusic;
    public AudioClip lastLevelMusic;

    private int currentScene;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;

        if (currentScene == 0)
        {
            audioSource.clip = mainMenuMusic;

        }
        else if (currentScene == 1)
        {
            audioSource.clip = spawnMusic;
        }
        else if (currentScene == 2)
        {
            audioSource.clip = firstLevelMusic;
        }
        else if (currentScene == 3)
        {
            audioSource.clip = lastLevelMusic;
        }
        else
        {
            Debug.Log("no music to play");
        }
        audioSource.Play();
    }

    private void Update()
    {
        audioSource.volume = musicVolume*0.2f;
    }

}
