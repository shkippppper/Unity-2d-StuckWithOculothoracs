using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;

    public GameObject dontDestroy;
    public PlayerArtifacts playerArtifacts;

    private void Awake()
    {
        dontDestroy = GameObject.Find("DontDestroy");
        playerArtifacts = dontDestroy.GetComponent<PlayerArtifacts>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(StartInOne), 0.0001f);

    }


    public void StartInOne()
    {
        playerArtifacts.dialogue += 1;
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());

    }
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else { gameObject.SetActive(false); }
    }
}
