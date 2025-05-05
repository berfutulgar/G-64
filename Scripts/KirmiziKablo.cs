using UnityEngine;

public class KirmiziKablo : MonoBehaviour
{
    public GameObject duzKablo;

    void OnMouseDown()
    {
        if (duzKablo != null)
            duzKablo.SetActive(true);

        gameObject.SetActive(false);
    }
}
