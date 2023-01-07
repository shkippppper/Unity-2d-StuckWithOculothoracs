using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogue0;
    public GameObject dialogue1;
    public GameObject dialogue2;
    public GameObject dialogue3;

    public GameObject dontDestroy;
    public PlayerArtifacts playerArtifacts;

    private void Awake()
    {
        dontDestroy = GameObject.Find("DontDestroy");
        playerArtifacts = dontDestroy.GetComponent<PlayerArtifacts>();
    }

    private void Start()
    {
        bool haveFirst = playerArtifacts.haveEvolution && playerArtifacts.haveTime && playerArtifacts.haveLightning && playerArtifacts.haveFire && playerArtifacts.haveWater && playerArtifacts.haveEarth;
        bool haveSecond = playerArtifacts.haveVoid && playerArtifacts.haveStrength && playerArtifacts.haveSight && playerArtifacts.haveFear && playerArtifacts.haveDragonsEgg && playerArtifacts.haveDragonsTooth;
        
        if (playerArtifacts.dialogue == 0)
        {
            dialogue0.SetActive(true);
            dialogue1.SetActive(false);
            dialogue2.SetActive(false);
            dialogue3.SetActive(false);
        }
        else if (playerArtifacts.dialogue == 1)
        {
            dialogue0.SetActive(false);
            dialogue1.SetActive(true);
            dialogue2.SetActive(false);
            dialogue3.SetActive(false);
            if (playerArtifacts.haveEvolution)
            {
                dialogue1.SetActive(true);
            }
        }
        else if (playerArtifacts.dialogue == 2)
        {
            dialogue0.SetActive(false);
            dialogue1.SetActive(false);
            dialogue2.SetActive(false);
            dialogue3.SetActive(false);

            if (haveFirst)
            {
                dialogue2.SetActive(true);
            }
        }
        else if (playerArtifacts.dialogue == 3)
        {
            dialogue0.SetActive(false);
            dialogue1.SetActive(false);
            dialogue2.SetActive(false);
            dialogue3.SetActive(false);

            if(haveFirst & haveSecond)
            {
                dialogue3.SetActive(true);
            }
        }

    }

}
