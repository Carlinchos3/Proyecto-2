using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]

public class MovimientoPlayerCirculo : MonoBehaviour
{
    private Rigidbody2D rb;
    private KeyCode[] movementKeys;
    private Vector2[] movementVectors;

    [field: SerializeField] public float movementForce { get; private set; } = 10.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movementKeys = new KeyCode[4] { KeyCode.W, KeyCode.S, KeyCode.A, KeyCode.D };
        movementVectors = new Vector2[4] { Vector2.up, Vector2.down, Vector2.left, Vector2.right };
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < movementKeys.Length; i++)
        {
            if(Input.GetKey(movementKeys[i]))
            {
                rb.AddForce(movementVectors[i] * movementForce);
            }
        }
    }
}
