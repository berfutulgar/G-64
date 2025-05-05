using UnityEngine;
using UnityEngine.SceneManagement;

public class SeaweedManager : MonoBehaviour
{
    public int totalSeaweeds = 0;
    public string nextScene = "Platform";

    public void SeaweedDestroyed()
    {
        totalSeaweeds--;

        if (totalSeaweeds <= 0)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
