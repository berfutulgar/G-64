using UnityEngine;

public class PowerBarController : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite redSprite;
    public Sprite orangeSprite;
    public Sprite greenSprite;

    public LightController[] allLights;

    void Update()
    {
        int greenCount = 0;
        int orangeCount = 0;

        foreach (LightController light in allLights)
        {
            if (light.currentState == LightController.LightState.Green)
                greenCount++;
            else if (light.currentState == LightController.LightState.Yellow)
                orangeCount++;
        }

        if (greenCount == allLights.Length)
        {
            sr.sprite = greenSprite;
        }
        else if (greenCount + orangeCount == allLights.Length)
        {
            sr.sprite = orangeSprite;
        }
        else
        {
            sr.sprite = redSprite;
        }
    }
}
