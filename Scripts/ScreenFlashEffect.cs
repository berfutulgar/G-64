using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenFlashEffect : MonoBehaviour
{
    public Image flashImage;
    public float fadeSpeed = 10f;
    private bool startFlash = false;

    void Update()
    {
        if (startFlash)
        {
            Color color = flashImage.color;
            color.a = Mathf.MoveTowards(color.a, 1f, fadeSpeed * Time.deltaTime);
            flashImage.color = color;

            if (color.a >= 1f)
            {
                SceneManager.LoadScene("TopDownScene"); 
            }
        }
    }

    public void StartFlash()
    {
        startFlash = true;
    }
}
