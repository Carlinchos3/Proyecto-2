using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class testCode : MonoBehaviour
{
    UnityEvent OnDeath;
    int health = 0;

    public void Start()
    {
        OnDeath.AddListener(DeathAnimation);
    }
    public void ReciveDamage(int dmg)
    {
        health -= dmg;
        if(health <= 0)
        {
            OnDeath.Invoke();
        }
    }

    public void DeathAnimation()
    {
        Debug.Log("I ded");
    }

}
