using UnityEngine;

public class BarometerNeedle : MonoBehaviour
{
    public float currentValue = 100f; 
    public float minValue = 0f;
    public float maxValue = 100f;
    public float minAngle = 90f; 
    public float maxAngle = -90f; 

    void Update()
    {
        float t = Mathf.InverseLerp(minValue, maxValue, currentValue);
        float angle = Mathf.Lerp(minAngle, maxAngle, t);
        transform.localRotation = Quaternion.Euler(0, 0, angle);
    }

    public void DecreaseValue(float amount)
    {
        currentValue = Mathf.Max(minValue, currentValue - amount);
    }
}
