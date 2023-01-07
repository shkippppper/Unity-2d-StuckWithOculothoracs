using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactsManager : MonoBehaviour
{
    public GameObject dontDestroy;
    public PlayerArtifacts playerArtifacts;

    public GameObject dragonsEgg;
    public GameObject dragonsTooth;
    public GameObject earth;
    public GameObject evolution;
    public GameObject fear;
    public GameObject fire;
    public GameObject lightning;
    public GameObject sight;
    public GameObject strength;
    public GameObject time;
    public GameObject voidG;
    public GameObject water;



    private void Awake()
    {
        dontDestroy = GameObject.Find("DontDestroy");
        playerArtifacts = dontDestroy.GetComponent<PlayerArtifacts>();
    }

    void Update()

    {
        Invoke(nameof(HaveArtifacts), 0.001f);
    }


    public void HaveArtifacts()
    {
        if (playerArtifacts.haveDragonsEgg)
        {
            dragonsEgg.SetActive(true);
        }
        if (playerArtifacts.haveDragonsTooth)
        {
            dragonsTooth.SetActive(true);
        }
        if (playerArtifacts.haveEarth)
        {
            earth.SetActive(true);
        }
        if (playerArtifacts.haveEvolution)
        {
            evolution.SetActive(true);
        }
        if (playerArtifacts.haveFear)
        {
            fear.SetActive(true);
        }
        if (playerArtifacts.haveFire)
        {
            fire.SetActive(true);
        }
        if (playerArtifacts.haveLightning)
        {
            lightning.SetActive(true);
        }
        if (playerArtifacts.haveSight)
        {
            sight.SetActive(true);
        }
        if (playerArtifacts.haveStrength)
        {
            strength.SetActive(true);
        }
        if (playerArtifacts.haveTime)
        {
            time.SetActive(true);
        }
        if (playerArtifacts.haveVoid)
        {
            voidG.SetActive(true);
        }
        if (playerArtifacts.haveWater)
        {
            water.SetActive(true);
        }

    }

}
