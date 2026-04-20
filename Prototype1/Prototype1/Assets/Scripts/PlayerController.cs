using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float fowardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {

    }
    // Update is called once per frame
    void Update()
    {
        // Move the vehicle foward
        horizontalInput = Input.GetAxis("Horizontal");
        fowardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
       
    }
}