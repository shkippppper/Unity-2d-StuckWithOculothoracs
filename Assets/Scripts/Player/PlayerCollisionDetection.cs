using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionDetection : MonoBehaviour
{
    public GameObject dontDestroyGameobject;
    public PlayerArtifacts playerArtifacts;
    public GameObject gameManagerGO;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = gameManagerGO.GetComponent<GameManager>();
        dontDestroyGameobject = GameObject.Find("DontDestroy");
        playerArtifacts = dontDestroyGameobject.GetComponent<PlayerArtifacts>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            Death();
        }

        if(collision.gameObject.layer == 9)
        {
            playerArtifacts.ArtifactTaken(collision.gameObject.name);
            Destroy(collision.gameObject);
            Win();
        }

    }



    private void Death()
    {

        gameManager.RestartRound();

    }

    private void Win()
    {
        gameManager.Win();
    }
}
