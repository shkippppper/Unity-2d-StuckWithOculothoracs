using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Animator blackWhiteAnim;

    public GameObject soundManagment;
    private SoundManager soundManager;
    private void Awake()
    {
        soundManager = soundManagment.GetComponent<SoundManager>();
    }
    public void RestartRound()
    {
        blackWhiteAnim.SetTrigger("MakeWhite");
        Invoke(nameof(RestartScene), 1f);
    }


    public void RestartScene()
    {
        var thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);
    }
    
    public void Win()
    {
        soundManager.PlayOneShot("collect");
        blackWhiteAnim.SetTrigger("MakeWhite");
        Invoke(nameof(FirstScene), 1f);
    }


    public void FirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
