using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuImageAnimator : MonoBehaviour
{
    public float backgroundMovespeed =100000f;
    private float offset = 0f;
    private RectTransform rectTransform;
    private float startPoisitonX;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Start()
    {
        startPoisitonX = rectTransform.anchoredPosition.x;
    }

    // Update is called once per frame
    void Update()
    {
        offset = offset + backgroundMovespeed * Time.deltaTime;
        rectTransform.anchoredPosition = new Vector2(startPoisitonX-backgroundMovespeed*offset*10, 0);

        if(offset*10 > 1600)
        {
            rectTransform.anchoredPosition = new Vector2(1600, 0);
            offset = 0;
        }

    }
}
