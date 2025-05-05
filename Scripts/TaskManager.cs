using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public GameObject tasetki; 
    private int solvedCount = 0;

    public void TaskSolved()
    {
        solvedCount++;

        if (solvedCount >= 1 && tasetki != null)
        {
            tasetki.SetActive(true);
        }
    }
}
