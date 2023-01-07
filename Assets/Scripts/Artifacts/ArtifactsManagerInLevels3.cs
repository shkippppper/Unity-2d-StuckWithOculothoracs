using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactsManagerInLevels3 : MonoBehaviour
{
    public GameObject dontDestroy;
    public PlayerArtifacts playerArtifacts;

    public GameObject evolution;



    private void Awake()
    {
        dontDestroy = GameObject.Find("DontDestroy");
        playerArtifacts = dontDestroy.GetComponent<PlayerArtifacts>();
    }


    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(HaveArtifacts), 0.1f);
    }

    public void HaveArtifacts()
    {
        //if (playerArtifacts.haveDragonsEgg)
        //{
        //    dragonsEgg.SetActive(false);
        //}

        //if (playerArtifacts.haveDragonsTooth)
        //{
        //    dragonsTooth.SetActive(false);
        //}

        //if (playerArtifacts.haveEarth)
        //{
        //    earth.SetActive(false);
        //}
        if (playerArtifacts.haveEvolution)
        {
            evolution.SetActive(false);
        }

        //if (playerArtifacts.haveFear)
        //{
        //    fear.SetActive(false);
        //}

        //if (playerArtifacts.haveFire)
        //{
        //    fire.SetActive(false);
        //}

        //if (playerArtifacts.haveLightning)
        //{
        //    lightning.SetActive(false);
        //}

        //if (playerArtifacts.haveSight)
        //{
        //    sight.SetActive(false);
        //}

        //if (playerArtifacts.haveStrength)
        //{
        //    strength.SetActive(false);
        //}

        //if (playerArtifacts.haveTime)
        //{
        //    time.SetActive(false);
        //}

        //if (playerArtifacts.haveVoid)
        //{
        //    voidG.SetActive(false);
        //}

        //if (playerArtifacts.haveWater)
        //{
        //    water.SetActive(false);
        //}

    }
}
