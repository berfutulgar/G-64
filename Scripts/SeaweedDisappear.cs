using UnityEngine;

public class SeaweedDisappear : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<SeaweedManager>().SeaweedDestroyed();
            Destroy(gameObject);
        }
    }
}
