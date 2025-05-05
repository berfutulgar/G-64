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
            textElement.text = "Ah! Paralel evrende bir ahtapot muymuþum?";
            state = 1;
            Invoke("ShowNextText", delayBetweenTexts);
        }
        else if (state == 1)
        {
            textElement.text = "Olamaz denizaltýmda arýza var.Önce bunu çözmeliyim";
            state = 2;
            Invoke("ShowNextText", delayBetweenTexts);
        }
        else if (state == 2)
        {
            textElement.text = "Sonra da taþ nerede onu bulmalýyým.";
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
