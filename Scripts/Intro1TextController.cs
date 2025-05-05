using UnityEngine;
using TMPro;
using System.Collections;


public class Intro1TextController : MonoBehaviour
{
    public TextMeshProUGUI storyText;
    public float delay = 3f;

    void Start()
    {
        StartCoroutine(ShowTexts());
    }

    IEnumerator ShowTexts()
    {
        storyText.text = "Buralarda bir yerde olmalý";
        yield return new WaitForSeconds(delay);

        storyText.text = "Heh! Sanýrým taþlarýn orada";
        yield return new WaitForSeconds(delay);

        storyText.text = "";
    }
}
