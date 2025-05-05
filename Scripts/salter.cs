using UnityEngine;

public class salter : MonoBehaviour
{
    public LightController[] allLights;
    public GameObject salterObjesi;

    void Update()
    {
        if (HepsiYesilMi())
        {
            if (!salterObjesi.activeSelf)
                salterObjesi.SetActive(true);
        }
        else
        {
            if (salterObjesi.activeSelf)
                salterObjesi.SetActive(false);
        }
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
