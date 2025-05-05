using UnityEngine;
using UnityEngine.SceneManagement;

public class StoneToTopdown : MonoBehaviour
{
    private bool triggered = false;

    public ScreenFlashEffect flashEffect;
    public CameraShake cameraShake;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (triggered) return;

        if (other.CompareTag("Player"))
        {
            triggered = true;

            if (flashEffect != null) flashEffect.StartFlash();
            if (cameraShake != null) cameraShake.Shake();

            Invoke("LoadScene", 1f); 
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene("TopDownScene");
    }
}
