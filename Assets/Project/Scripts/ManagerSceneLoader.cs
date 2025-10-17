using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerSceneLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyUp(KeyCode.Escape))
        {
            TestSingleton.Instance.SayHi();
        }


        if(Input.GetKeyDown(KeyCode.Alpha1) && !SceneManager.GetSceneByName("Triangulo").isLoaded)
        {
            SceneManager.LoadScene("Triangulo", LoadSceneMode.Additive);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) && SceneManager.GetSceneByName("Triangulo").isLoaded)
        {
            SceneManager.UnloadSceneAsync("Triangulo");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2) && !SceneManager.GetSceneByName("Redonda").isLoaded)
        {
            SceneManager.LoadScene("Redonda", LoadSceneMode.Additive);
        }
        
        else if (Input.GetKeyDown(KeyCode.Alpha2) && SceneManager.GetSceneByName("Redonda").isLoaded)
        {
            SceneManager.UnloadSceneAsync("Redonda");
        }
    }
}
