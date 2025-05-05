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
        storyText.text = "Buralarda bir yerde olmal�";
        yield return new WaitForSeconds(delay);

        storyText.text = "Heh! San�r�m ta�lar�n orada";
        yield return new WaitForSeconds(delay);

        storyText.text = "";
    }
}
