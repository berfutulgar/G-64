using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleCheck : MonoBehaviour
{
    public static int TotalSnapped = 0;
    public int totalPieces = 3;
    public int arizaNo = 1;

    private bool tamamlandi = false;

    void Update()
    {
        if (!tamamlandi && TotalSnapped >= totalPieces)
        {
            tamamlandi = true;

            PlayerPrefs.SetInt("Ariza" + arizaNo + "_Dondu", 1);
            PlayerPrefs.Save();

            Invoke(nameof(GeriDon), 1f); 
        }
    }

    void GeriDon()
    {
        TotalSnapped = 0;
        SceneManager.LoadScene("TopDownScene"); 
    }

    void OnEnable()
    {
        TotalSnapped = 0;
    }
}
