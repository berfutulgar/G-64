using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniOyun : MonoBehaviour
{
    public GameObject airFilter;
    public GameObject dogrukarisim;
    public GameObject yanliskarisim;

    public GameObject redLiquid;
    public GameObject greenLiquid;
    public GameObject blueLiquid;

    public Transform[] liquidLayers;

    private List<string> correctOrder = new List<string> { "I", "X", "L" }; // DOÐRU SIRA BURADA
    private List<string> addedOrder = new List<string>();
    private List<GameObject> instantiatedLiquids = new List<GameObject>();
    private int currentIndex = 0;

    public void AddChemical(string chem)
    {
        if (currentIndex >= 3) return;

        GameObject newLiquid = null;

        if (chem == "I") newLiquid = Instantiate(redLiquid);
        else if (chem == "L") newLiquid = Instantiate(greenLiquid);
        else if (chem == "X") newLiquid = Instantiate(blueLiquid);

        if (newLiquid != null && currentIndex < liquidLayers.Length)
        {
            newLiquid.transform.position = liquidLayers[currentIndex].position;
            newLiquid.SetActive(true);
            instantiatedLiquids.Add(newLiquid);
        }

        addedOrder.Add(chem);
        currentIndex++;

        if (currentIndex == 3)
            CheckSolution();
    }

    void CheckSolution()
    {
        bool correct = true;
        for (int i = 0; i < 3; i++)
        {
            if (addedOrder[i] != correctOrder[i])
            {
                correct = false;
                break;
            }
        }

        HideAllLiquids();

        if (correct)
        {
            dogrukarisim.SetActive(true);
            airFilter.SetActive(false);

            PlayerPrefs.SetInt("karisim_tamamlandi", 1);

            Invoke("GoToPlatformScene", 2f);
        }
        else
        {
            yanliskarisim.SetActive(true);
            Invoke("ResetAll", 1f); // Yanlýþsa 1 sn sonra baþa al
        }
    }

    void HideAllLiquids()
    {
        foreach (GameObject liq in instantiatedLiquids)
        {
            Destroy(liq);
        }
        instantiatedLiquids.Clear();
    }

    void GoToPlatformScene()
    {
        SceneManager.LoadScene("PlatformScene");
    }

    public void ResetAll()
    {
        addedOrder.Clear();
        currentIndex = 0;

        dogrukarisim.SetActive(false);
        yanliskarisim.SetActive(false);
        airFilter.SetActive(true);

        HideAllLiquids();
    }
}
