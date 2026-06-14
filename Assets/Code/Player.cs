using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    void setup()
    {
        
    }
    //movement speed in units per second
    private float movementSpeed = 5f;

    void Update()
    {
        transform.position = transform.position + new Vector3(1, 0, 3);

    }
}