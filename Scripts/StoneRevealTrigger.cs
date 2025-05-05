using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class StoneRevealTrigger : MonoBehaviour
{
    public GameObject stone;
    public Image flashImage;
    public float flashDuration = 0.2f;
    public Color flashColor = Color.white;
    public float shakeDuration = 0.3f;
    public float shakeMagnitude = 0.1f;
    public string nextScene = "TopDown";

    private bool triggered = false;
    private Transform cam;

    void Start()
    {
        cam = Camera.main.transform;

        if (flashImage != null)
            flashImage.enabled = false;

        if (stone != null)
            stone.SetActive(false); 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (triggered || !other.CompareTag("Player")) return;

        triggered = true;
        StartCoroutine(RevealSequence());
    }

    IEnumerator RevealSequence()
    {
        if (stone != null)
            stone.SetActive(true);

        SpriteRenderer sr = stone.GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            Color originalColor = sr.color;
            sr.color = Color.yellow;
            yield return new WaitForSeconds(0.2f);
            sr.color = originalColor;
        }

        if (flashImage != null)
        {
            flashImage.color = flashColor;
            flashImage.enabled = true;
            yield return new WaitForSeconds(flashDuration);
            flashImage.enabled = false;
        }


        Vector3 originalPos = cam.localPosition;
        float elapsed = 0f;
        while (elapsed < shakeDuration)
        {
            Vector2 offset = Random.insideUnitCircle * shakeMagnitude;
            cam.localPosition = originalPos + (Vector3)offset;
            elapsed += Time.deltaTime;
            yield return null;
        }
        cam.localPosition = originalPos;


        SceneManager.LoadScene(nextScene);
    }
}
