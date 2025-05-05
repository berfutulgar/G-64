using UnityEngine;

public class TornavidaManager : MonoBehaviour
{
    public static bool tornavidaAlindi = false;

    void OnMouseDown()
    {
        tornavidaAlindi = true;
        gameObject.SetActive(false); 
    }
}
