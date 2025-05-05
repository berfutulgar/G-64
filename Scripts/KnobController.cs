using UnityEngine;
using UnityEngine.SceneManagement;

public class KnobController : MonoBehaviour
{
    public Transform pointer;
    public float targetAngle = 270f;
    public LightController linkedLight;

    public GameObject salteracik;
    public LightController[] allLights;

    private bool isDragging = false;
    private bool sahneGecildi = false;

    void Update()
    {
        HandleDrag();
        CheckPowerMatch();

        if (salteracik != null && allLights != null && allLights.Length > 0)
        {
            if (HepsiYesilMi())
            {
                salteracik.SetActive(true);

                if (!sahneGecildi)
                {
                    sahneGecildi = true;
                    PlayerPrefs.SetInt("elektrik_acildi", 1);
                    SceneManager.LoadScene("PlatformScene");
                }
            }
            else
            {
                salteracik.SetActive(false);
            }
        }
    }

    void HandleDrag()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(mouseWorld, transform.position) < 1f)
                isDragging = true;
        }

        if (Input.GetMouseButtonUp(0))
            isDragging = false;

        if (isDragging)
        {
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mouseWorld - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
            pointer.rotation = Quaternion.Euler(0, 0, angle);
        }
    }

    void CheckPowerMatch()
    {
        float currentAngle = pointer.eulerAngles.z;
        float diff = Mathf.Abs(Mathf.DeltaAngle(currentAngle, targetAngle));

        if (diff < 10f)
            linkedLight.SetState(LightController.LightState.Green);
        else if (diff < 40f)
            linkedLight.SetState(LightController.LightState.Yellow);
        else
            linkedLight.SetState(LightController.LightState.Red);
    }

    bool HepsiYesilMi()
    {
        foreach (LightController light in allLights)
        {
            if (light.currentState != LightController.LightState.Green)
                return false;
        }
        return true;
    }
}
