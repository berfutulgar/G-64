using UnityEngine;

public class LightController : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite redSprite;
    public Sprite yellowSprite;
    public Sprite greenSprite;

    public enum LightState { Red, Yellow, Green }
    public LightState currentState;

    public void SetState(LightState state)
    {
        currentState = state;

        switch (state)
        {
            case LightState.Red:
                sr.sprite = redSprite;
                break;
            case LightState.Yellow:
                sr.sprite = yellowSprite;
                break;
            case LightState.Green:
                sr.sprite = greenSprite;
                break;
        }
    }

    public bool IsGreen()
    {
        return currentState == LightState.Green;
    }
}
