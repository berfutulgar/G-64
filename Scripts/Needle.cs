using UnityEngine;

public class Needle : MonoBehaviour
{
    public float minAngle = 0f;
    public float maxAngle = -90f;
    public float decrement = 5f;

    private float currentAngle;

    void Start()
    {
        currentAngle = minAngle;
        transform.rotation = Quaternion.Euler(0, 0, currentAngle);
    }

    public void MoveNeedle()
    {
        if (currentAngle > maxAngle)
        {
            currentAngle -= decrement;
            currentAngle = Mathf.Max(currentAngle, maxAngle);
            transform.rotation = Quaternion.Euler(0, 0, currentAngle);
        }
    }

    public bool IsFinished()
    {
        return currentAngle <= maxAngle;
    }
}
