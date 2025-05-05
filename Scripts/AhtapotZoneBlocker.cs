using UnityEngine;

public class AhtapotZoneBlocker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Ahtapot iceri girmeye calisinca geri iter
            Vector2 pushDir = other.transform.position - transform.position;
            pushDir = pushDir.normalized;

            other.transform.position += (Vector3)pushDir * 1f;
        }
    }
}
