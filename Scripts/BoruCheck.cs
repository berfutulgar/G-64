using UnityEngine;
using UnityEngine.SceneManagement;

public class BoruCheck : MonoBehaviour
{
    public static int TotalSnapped = 0;     
    public int totalPieces = 11;             
    public int boru = 1;                    

    private bool tamamlandi = false;

    void Update()
    {
        
        if (!tamamlandi && TotalSnapped >= totalPieces)
        {
            tamamlandi = true;

           
            PlayerPrefs.SetInt("borular_tamamlandi", 1);
            PlayerPrefs.Save();

            
            Invoke(nameof(GeriDon), 2f);
        }
    }

    void GeriDon()
    {
        TotalSnapped = 0;
        SceneManager.LoadScene("PlatformScene");
    }

    void OnEnable()
    {
       
        TotalSnapped = 0;
    }
}
