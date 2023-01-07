using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalOpener : MonoBehaviour
{
    public GameObject firstPortal;
    public GameObject secondPortal;

    public GameObject dontDestroy;
    public PlayerArtifacts playerArtifacts;

    private void Awake()
    {
        dontDestroy = GameObject.Find("DontDestroy");
        playerArtifacts = dontDestroy.GetComponent<PlayerArtifacts>();
    }

    private void Update()
    {
        bool haveFirst = playerArtifacts.haveEvolution && playerArtifacts.haveTime && playerArtifacts.haveLightning && playerArtifacts.haveFire && playerArtifacts.haveWater && playerArtifacts.haveEarth;
        bool haveSecond = playerArtifacts.haveVoid && playerArtifacts.haveStrength && playerArtifacts.haveSight && playerArtifacts.haveFear && playerArtifacts.haveDragonsEgg && playerArtifacts.haveDragonsTooth;


        if(haveFirst && haveSecond)
        {
            CloseSecondPortal();
        }

        else if (haveFirst)
        {
            OpenSecondPortal();
        }

        else if (playerArtifacts.haveEvolution)
        {
            OpenFirstPortal();
        }





    }



    private void OpenFirstPortal()
    {
        firstPortal.SetActive(true);
    }

    private void OpenSecondPortal()
    {
        firstPortal.SetActive(false);
        secondPortal.SetActive(true);
    }

    private void CloseSecondPortal()
    {
        secondPortal.SetActive(false);

    }

}
