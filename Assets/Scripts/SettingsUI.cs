using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject soundManagerGameobject;
    public GameObject musicManagerGameobject;
    private SoundManager soundManager;
    private MusicManager musicManager;

    public Animator blackWhiteAnim;
    public Slider musicVolumeSlider;
    public Slider soundVolumeSlider;
    

    public float musicalVolume=0.5f;
    public float soundalVolume=0.5f;


    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void Awake()
    {
        musicManager = musicManagerGameobject.GetComponent<MusicManager>();
        soundManager = soundManagerGameobject.GetComponent<SoundManager>();

    }

    public void RespawnBtn()
    {
        blackWhiteAnim.SetTrigger("MakeWhite");
        Invoke(nameof(Respawn), 1f);
    }

    public void Respawn()
    {
        var thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);
    }

    private void Start()
    {


        if (!PlayerPrefs.HasKey("music"))
        {
            PlayerPrefs.SetFloat("music", 0.25f);
        }

        if (!PlayerPrefs.HasKey("sound"))
        {
            PlayerPrefs.SetFloat("sound", 0.25f);
        }

        musicalVolume = PlayerPrefs.GetFloat("music");
        soundalVolume = PlayerPrefs.GetFloat("sound");

        musicVolumeSlider.value = musicalVolume;
        soundVolumeSlider.value = soundalVolume;


    }

    private void Update()
    {

        musicalVolume = musicVolumeSlider.value;
        soundalVolume = soundVolumeSlider.value;

        musicManager.musicVolume = musicalVolume;
        soundManager.soundVolume = soundalVolume;

        PlayerPrefs.SetFloat("music", musicalVolume);
        PlayerPrefs.SetFloat("sound", soundalVolume);



        if (Input.GetButtonDown("Cancel"))
        {
            if (transform.GetChild(0).gameObject.activeInHierarchy)
            {
                transform.GetChild(0).gameObject.SetActive(false);
            }
            else
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }
        }



    }



}
