using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

    private bool colliding = false;
    public Animator blackWhiteAnim;
    public GameObject soundManagment;
    private SoundManager soundManager;
    public GameObject dontDestroy;
    public PlayerArtifacts playerArtifacts;

    private void Awake()
    {
        soundManager = soundManagment.GetComponent<SoundManager>();
        dontDestroy = GameObject.Find("DontDestroy");
        playerArtifacts = dontDestroy.GetComponent<PlayerArtifacts>();
    }

    private void Start()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);

    }

    private void Update()
    {
        //check if the name of the portal and the gameobject match
        if(gameObject.name == "TheEnd")
        {
            //check if the child component is active
            if (transform.GetChild(0).gameObject.activeInHierarchy)
            {
                //check if E was clicked
                if (Input.GetKeyDown(KeyCode.E))
                {
                    playerArtifacts.dialogue = 0;
                    blackWhiteAnim.SetTrigger("MakeWhite");
                    Invoke(nameof(RestartGame), 3f);

                }
            }
        }

        //check if the name of the portal and the gameobject match
        if (gameObject.name == "OverWorld")
        {
            //check if the child component is active
            if (transform.GetChild(0).gameObject.activeInHierarchy)
            {
                //check if E was clicked
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if(SceneManager.GetActiveScene().buildIndex == 1)
                    {
                        soundManager.PlayOneShot("portal");
                        blackWhiteAnim.SetTrigger("MakeWhite");
                        Invoke(nameof(LoadOverWorld), 1f);
                    }
                    else
                    {
                        soundManager.PlayOneShot("portal");
                        blackWhiteAnim.SetTrigger("MakeWhite");
                        Invoke(nameof(LoadSpawn), 1f);
                    }
                }
            }
        }

        if (gameObject.name == "UnderWorld")
        {
            //check if the child component is active
            if (transform.GetChild(0).gameObject.activeInHierarchy)
            {
                //check if E was clicked
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (SceneManager.GetActiveScene().buildIndex == 1)
                    {
                        soundManager.PlayOneShot("portal");
                        blackWhiteAnim.SetTrigger("MakeWhite");
                        Invoke(nameof(LoadUnderWorld), 1f);
                    }
                    else
                    {
                        soundManager.PlayOneShot("portal");
                        blackWhiteAnim.SetTrigger("MakeWhite");
                        Invoke(nameof(LoadSpawn), 1f);
                    }
                }
            }
        }


    }

    private void LoadSpawn()
    {
        SceneManager.LoadScene(1);
    }

    private void LoadOverWorld()
    {
        SceneManager.LoadScene(2);

    }
    private void LoadUnderWorld()
    {
        SceneManager.LoadScene(3);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        gameObject.transform.GetChild(0).gameObject.SetActive(false);

    }


    private void RestartGame()
    {
        SceneManager.LoadScene(1);
        playerArtifacts.haveDragonsEgg = false;
        playerArtifacts.haveDragonsTooth = false;
        playerArtifacts.haveEarth = false;
        playerArtifacts.haveEvolution = false;
        playerArtifacts.haveFear = false;
        playerArtifacts.haveFire = false;
        playerArtifacts.haveLightning = false;
        playerArtifacts.haveSight = false;
        playerArtifacts.haveStrength = false;
        playerArtifacts.haveTime = false;
        playerArtifacts.haveVoid = false;
        playerArtifacts.haveWater = false;

    }



}
