using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogueDisplay;
    public TextMeshProUGUI nameDisplay;
    public string[] sentences;
    public string[] names;
    public int index;
    public float typingSpeed;
    bool canContinue = false;

    void Start()
    {
        StartCoroutine(Type());
    }
    void Update()
    {
        if (dialogueDisplay.text == sentences[index])
        {
            canContinue = true;
        }
        if (Input.GetKey(KeyCode.Space) && canContinue)
        {
            NextSentence();
        }
    }
    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            dialogueDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    public void NextSentence()
    {
        canContinue = false;
        if (index < sentences.Length - 1)
        {
            index++;
            dialogueDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            dialogueDisplay.text = "";
            canContinue = false;
        }
    }
}