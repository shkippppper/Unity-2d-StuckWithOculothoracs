using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerArtifacts : MonoBehaviour
{
    public bool haveVoid;
    public bool haveTime;
    public bool haveFire;
    public bool haveLightning;
    public bool haveWater;
    public bool haveDragonsTooth;
    public bool haveDragonsEgg;
    public bool haveEarth;
    public bool haveEvolution;
    public bool haveStrength;
    public bool haveFear;
    public bool haveSight;

    public int dialogue;

    public void ArtifactTaken(string artifact)
    {
        
        Invoke(artifact, 0.1f);

    }

    private void ArtifactOfVoid()
    {
        haveVoid = true;
    }

    private void ArtifactOfTime()
    {
        haveTime = true;
    }

    private void ArtifactOfFire()
    {
        haveFire = true;
    }

    private void ArtifactOfLightning()
    {
        haveLightning = true;
    }

    private void ArtifactOfWater()
    {
        haveWater = true;
    }

    private void ArtifactOfDragonsTooth()
    {
        haveDragonsTooth = true;
    }

    private void ArtifactOfDragonsEgg()
    {
        haveDragonsEgg = true;
    }

    private void ArtifactOfEarth()
    {
        haveEarth = true;
    }

    private void ArtifactOfEvolution()
    {
        haveEvolution = true;
    }

    private void ArtifactOfStrength()
    {
        haveStrength = true;
    }
    private void ArtifactOfFear()
    {
        haveFear = true;
    }
    private void ArtifactOfSight()
    {
        haveSight = true;
    }

}
