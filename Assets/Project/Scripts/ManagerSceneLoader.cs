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


      if(Input.GetKeyDown(KeyCode.Alpha1) && !SceneManager.GetSceneByName("Scene 1").isLoaded)
        {
            SceneManager.LoadScene("Scene 1",LoadSceneMode.Additive);
        }
      else if(Input.GetKeyDown(KeyCode.Alpha2) && !SceneManager.GetSceneByName("Scene 2").isLoaded)
        {
            SceneManager.LoadScene("Scene 2",LoadSceneMode.Additive);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) && SceneManager.GetSceneByName("Scene 1").isLoaded)
        {
            SceneManager.UnloadSceneAsync("Scene 1");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && SceneManager.GetSceneByName("Scene 2").isLoaded)
        {
            SceneManager.UnloadSceneAsync("Scene 2");
        }
    }
}
