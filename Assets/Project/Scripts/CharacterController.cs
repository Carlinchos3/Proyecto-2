using UnityEngine;

public class CharacterController : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 forceDirection = Vector2.right;
        float forceStrenght = 10.0f;

        GetComponent<Rigidbody2D>().AddForce (forceDirection * forceStrenght);
    }
}
