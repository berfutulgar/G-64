using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public float targetY = 0f;        
    public float speed = 2f;        

    void Update()
    {
        Vector3 pos = transform.position;
        if (pos.y > targetY)
        {
            pos.y -= speed * Time.deltaTime;
            if (pos.y < targetY) pos.y = targetY; 
            transform.position = pos;
        }
    }
}
