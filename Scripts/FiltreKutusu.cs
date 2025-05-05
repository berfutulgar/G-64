using UnityEngine;
using UnityEngine.SceneManagement;

public class FiltreKutusu : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("karisim_tamamlandi", 0) == 1)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Filtre");
        }
    }
}
