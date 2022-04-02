using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TitleScreenHandler : MonoBehaviour
{
    public float blinkTime = 0.4F;
    public GameObject textTMP;
    bool run = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TextBlink());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(1);
        }
        
    }
    private IEnumerator TextBlink()
    {
        while (run)
        {
            if (textTMP.activeInHierarchy)
            {
                textTMP.SetActive(true);
            }
            else
            {
                textTMP.SetActive(false);
            }
            yield return new WaitForSeconds(blinkTime);
        }
        yield break;
    }
}
