using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TopDownSceneTextController : MonoBehaviour
{
    public TextMeshProUGUI textElement;
    public float delayBetweenTexts = 1f;
    private int state = 0;

    void Start()
    {
        ShowNextText();
    }

    void ShowNextText()
    {
        if (state == 0)
        {
            textElement.text = "Ah! Paralel evrende bir ahtapot muymu�um?";
            state = 1;
            Invoke("ShowNextText", delayBetweenTexts);
        }
        else if (state == 1)
        {
            textElement.text = "Olamaz denizalt�mda ar�za var.�nce bunu ��zmeliyim";
            state = 2;
            Invoke("ShowNextText", delayBetweenTexts);
        }
        else if (state == 2)
        {
            textElement.text = "Sonra da ta� nerede onu bulmal�y�m.";
            state = 3;
        }

    }

    public void OnStoneTouched()
    {
        textElement.text = "Iste burada!";
    }

    void GoToPlatformScene()
    {
        SceneManager.LoadScene("PlatformScene");
    }
}
