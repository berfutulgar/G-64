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
            storyText.text = "Y�llar s�ren haz�rl�klar sonunda...\nSon ad�m i�in derin sulara iniyorum.";
        }
        else if (y > -8)
        {
            storyText.text = "Bilim d�nyas�n�n g�zleri bu an�n �zerinde.";
        }
        else if (y > -16)
        {
            storyText.text = "Bu ta� sayesinde evrenler aras�nda seyahat edebilece�im!";
        }
        else
        {
            storyText.text = "Ama i�imde tuhaf bir his var...\nSanki ta� beni bekliyor.";

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