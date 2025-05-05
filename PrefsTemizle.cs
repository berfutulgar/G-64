using UnityEngine;

public class PrefsTemizle : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log(" PlayerPrefs temizlendi.");
    }
}
