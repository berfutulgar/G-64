using UnityEngine;

public class MiniFixTask : MonoBehaviour
{
    public string taskID = "ariza1"; 


    private bool completed = false;

    void Start()
    {
       
        if (PlayerPrefs.GetInt(taskID, 0) == 1)
        {
            gameObject.SetActive(false);
        }
    }

    void OnMouseDown()
    {
        if (completed || PlayerPrefs.GetInt(taskID, 0) == 1) return;

        completed = true;

       
        PlayerPrefs.SetInt(taskID, 1);
        PlayerPrefs.Save();

        Debug.Log("Görev tamamlandý: " + taskID);

     
        Destroy(gameObject);  
    }
}
