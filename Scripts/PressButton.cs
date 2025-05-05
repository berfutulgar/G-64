using UnityEngine;
using UnityEngine.SceneManagement;

public class PressButton : MonoBehaviour
{
    public Needle needle;

    private void OnMouseDown()
    {
        if (needle != null)
        {
            needle.MoveNeedle();

            if (needle.IsFinished())
            {
                SceneManager.LoadScene("PlatformScene");
            }
        }
    }
}
