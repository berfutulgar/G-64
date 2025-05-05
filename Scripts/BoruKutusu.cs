using UnityEngine;
using UnityEngine.SceneManagement;

public class BoruKutusu : MonoBehaviour
{
   public string sceneToLoad = "Borular";

    void Start()
    {
        if (PlayerPrefs.GetInt("borular_tamamlandi", 0) == 1)
        {
            gameObject.SetActive(false); 
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (PlayerPrefs.GetInt("borular_tamamlandi", 0) == 0)
            {
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}
