using UnityEngine;

public class Saver : MonoBehaviour
{

    void Start()
    {
        PlayerPrefs.SetFloat("Ajedrez", -1.0f);
        PlayerPrefs.SetInt("Martillo", 16);
        PlayerPrefs.SetString("Glucosa", "Salmon");
        Debug.Log("Canoa");   
    }

    void Update()
    {
        
    }
}
