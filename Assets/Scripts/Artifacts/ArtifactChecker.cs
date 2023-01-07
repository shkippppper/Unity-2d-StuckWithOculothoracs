using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactChecker : MonoBehaviour
{
    public GameObject endPortal;
    private int children;

    private void Start()
    {
        children = transform.childCount;
    }
    // Update is called once per frame

    private void Update()
    {
        if (AllChildrenActive())
        {
            endPortal.SetActive(true);
        }
    }

    public bool AllChildrenActive()
    {
        bool allActive = true; // flag to store whether all children are active

        // iterate over all child game objects
        foreach (Transform child in transform)
        {
            // check if the child game object is active
            if (!child.gameObject.activeInHierarchy)
            {
                allActive = false; // set the flag to false if any child is inactive
                break; // exit the loop
            }
        }

        return allActive; // return the value of the flag
    }
}
