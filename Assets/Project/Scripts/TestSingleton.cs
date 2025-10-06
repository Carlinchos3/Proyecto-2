using UnityEngine;

public class TestSingleton : MonoBehaviour
{

    public static TestSingleton Instance {  get; private set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);
        Instance = this;

    }

    public void SayHi()
    {
        Debug.Log("Hi");
    }

}
