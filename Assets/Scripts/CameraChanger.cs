using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraChanger : MonoBehaviour
{

    private Color normalColor;
    private Color underWorldColor;

    // Start is called before the first frame update
    void Start()
    {
        normalColor.r = 105;
        normalColor.g = 114;
        normalColor.b = 128;

        underWorldColor.r = 29;
        underWorldColor.g = 6;
        underWorldColor.b = 12;

        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            Camera.main.backgroundColor = underWorldColor;
        }
        else
        {
            Camera.main.backgroundColor = normalColor;
        }
        
    }


}
