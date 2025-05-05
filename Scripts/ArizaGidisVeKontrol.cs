using UnityEngine;
using UnityEngine.SceneManagement;

public class ArizaGidisVeKontrol : MonoBehaviour
{
    public int arizaNo = 1;
    public string miniSceneName = "MiniFixScene";

    void Start()
    {
        string key = "Ariza" + arizaNo + "_Dondu";
        if (PlayerPrefs.GetInt(key, 0) == 1)
        {
            gameObject.SetActive(false); 
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(miniSceneName); 
        }
    }
}
