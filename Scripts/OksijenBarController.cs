using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OksijenBarController : MonoBehaviour
{
    public Image oksijenBarFill;
    public float oksijenSuresi = 60f; // saniye
    private float kalanSure;

    void Start()
    {
        kalanSure = oksijenSuresi;
    }

    void Update()
    {
        kalanSure -= Time.deltaTime;
        float oran = Mathf.Clamp01(kalanSure / oksijenSuresi);
        oksijenBarFill.fillAmount = oran;

        if (kalanSure <= 0f)
        {
            SceneManager.LoadScene("TopDownScene");
        }
    }
}
