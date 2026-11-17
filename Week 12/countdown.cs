using System.Collections;
using UnityEngine;
using TMPro;

public class countdown : MonoBehaviour
{
public TMP_Text countdownText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(StartCountdown());
    }
    IEnumerator StartCountdown()
    {
        for (int i = 3; i>0; i--)
    {
         countdownText.text = i.ToString();
         yield return new WaitForSeconds(1f);
    }
    countdownText.text = "GO!";

    yield return new WaitForSeconds(1f);
    countdownText.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
