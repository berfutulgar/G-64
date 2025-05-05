using UnityEngine;

public class YukariCik : MonoBehaviour
{
    public float hedefY = 27f;      
    public float hiz = 2f;         

    void Update()
    {
        Vector3 pozisyon = transform.position;

        if (pozisyon.y < hedefY)
        {
            pozisyon.y += hiz * Time.deltaTime;
            transform.position = pozisyon;
        }
    }
}
