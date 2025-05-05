using UnityEngine;
using UnityEngine.SceneManagement;

public class ElektrikKutusu : MonoBehaviour
{
    void Start()
    {
        // Eðer elektrik zaten açýldýysa  kutuyu sahneden sil
        if (PlayerPrefs.GetInt("elektrik_acildi", 0) == 1)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Elektrik");  // Elektrik sahne adýný burada kullan
        }
    }
}
