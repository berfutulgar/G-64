using UnityEngine;

public class Vida : MonoBehaviour
{
    public GameObject gorselSonrasi;
    public GameObject[] yokOlacaklar;

    public static int toplamVidaSayisi = 4;
    public static int sokulenVidaSayisi = 0;

    private bool sokuldu = false;

    void OnMouseDown()
    {
        if (sokuldu || !TornavidaManager.tornavidaAlindi) return;

        sokuldu = true;
        sokulenVidaSayisi++;

        if (gorselSonrasi != null)
            gorselSonrasi.SetActive(true);

        gameObject.SetActive(false);

        if (yokOlacaklar.Length > 0 && sokulenVidaSayisi >= toplamVidaSayisi)
        {
            foreach (GameObject obj in yokOlacaklar)
            {
                if (obj != null)
                    obj.SetActive(false);
            }
        }
    }
}
