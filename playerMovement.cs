using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the Horizontal and vertical axis
        float translation = Input.GetAxis("Vertical") * speed;
        // Ma'am wala: transform.Translate(Vector3.right * Time.deltaTime * speed * forwardInput);
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // move 10 meters per second
        translation = translation * Time.deltaTime;
        rotation = rotation * Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);
    }
}
