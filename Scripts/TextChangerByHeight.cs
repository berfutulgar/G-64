using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextChangerByHeight : MonoBehaviour
{
    public TextMeshProUGUI storyText;
    public Transform cameraTransform;

    private bool hasSwitchedScene = false;

    void Update()
    {
        float y = cameraTransform.position.y;

        if (y > 0)
        {
            storyText.text = "Yýllar süren hazýrlýklar sonunda...\nSon adým için derin sulara iniyorum.";
        }
        else if (y > -8)
        {
            storyText.text = "Bilim dünyasýnýn gözleri bu anýn üzerinde.";
        }
        else if (y > -16)
        {
            storyText.text = "Bu taþ sayesinde evrenler arasýnda seyahat edebileceðim!";
        }
        else
        {
            storyText.text = "Ama içimde tuhaf bir his var...\nSanki taþ beni bekliyor.";

            if (!hasSwitchedScene)
            {
                hasSwitchedScene = true;
                Invoke("LoadNextScene", 4f);
            }
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("Intro1");
    }
}