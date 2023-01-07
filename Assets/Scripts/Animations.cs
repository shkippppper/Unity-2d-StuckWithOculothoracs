using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Animations : MonoBehaviour
{

    public GameObject backAnimatorGO;
    public GameObject backAnimatorTwoGO;
    public GameObject shkipperGO;
    public GameObject creditsGO;
    public GameObject playerGO;
    public GameObject mainTextGO;
    public GameObject mainMenuGO;
    public GameObject controlsGO;

    public Animator blackWhiteAnim;


    private Animator backAnimator;
    private Animator backAnimatorTwo;
    private Animator shkipperAnimator;
    private Animator creditsAnimator;
    private Animator playerAnimator;
    private Animator mainTextAnimator;
    private Animator mainMenuAnimator;
    private Animator controlsAnimator;


    private void Awake()
    {
        backAnimator = backAnimatorGO.GetComponent<Animator>();
        backAnimatorTwo = backAnimatorTwoGO.GetComponent<Animator>();
        shkipperAnimator = shkipperGO.GetComponent<Animator>();
        creditsAnimator = creditsGO.GetComponent<Animator>();
        playerAnimator = playerGO.GetComponent<Animator>();
        mainTextAnimator = mainTextGO.GetComponent<Animator>();
        mainMenuAnimator = mainMenuGO.GetComponent<Animator>();
        controlsAnimator = controlsGO.GetComponent<Animator>();
    }

    public void BackAnimatorOn()
    {
        backAnimator.SetTrigger("BackBtnOn");
    }

    public void BackAnimatorOff()
    {
        backAnimator.SetTrigger("BackBtnOff");
    }

    public void BackAnimatorTwoOn()
    {
        backAnimatorTwo.SetTrigger("BackBtnOn");
    }

    public void BackAnimatorTwoOff()
    {
        backAnimatorTwo.SetTrigger("BackBtnOff");
    }

    public void ShkipperOn()
    {
        shkipperAnimator.SetTrigger("ShkipperOn");
    }

    public void ShkipperOff()
    {
        shkipperAnimator.SetTrigger("ShkipperOff");
    }

    public void CreditsOn()
    {
        creditsAnimator.SetTrigger("CreditsOn");
    }

    public void CreditsOff()
    {
        creditsAnimator.SetTrigger("CreditsOff");
    }

    public void PlayerOn()
    {
        playerAnimator.SetTrigger("PlayerOn");
    }

    public void PlayerOff()
    {
        playerAnimator.SetTrigger("PlayerOff");
    }

    public void MainTextOn()
    {
        mainTextAnimator.SetTrigger("MainTextOn");
    }

    public void MainTextOff()
    {
        mainTextAnimator.SetTrigger("MainTextOff");
    }

    public void MainMenuOn()
    {
        mainMenuAnimator.SetTrigger("MainMenuOn");
    }

    public void MainMenuOff()
    {
        mainMenuAnimator.SetTrigger("MainMenuOff");
    }

    public void ControlsOn()
    {
        controlsAnimator.SetTrigger("ControlsOn");
    }

    public void ControlsOff()
    {
        controlsAnimator.SetTrigger("ControlsOff");
    }


    public void QuitGameClicked()
    {
        blackWhiteAnim.SetTrigger("MakeWhite");
        Invoke(nameof(QuitGame), 1f);
    }

    public void PlayGameClicked()
    {
        blackWhiteAnim.SetTrigger("MakeWhite");
        Invoke(nameof(PlayGame), 1f);
    }

    private void QuitGame()
    {
        Application.Quit();
    }

    private void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
