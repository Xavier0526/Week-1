using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    Vector3 newPosition = new Vector3(0.005f, 0f, 0.005f);
    
    float moveLimit = 5f;
    float rotationSpeed = 100f;
    float rotationLimit = 45f;

    int moveDirection = 1;
    int rotateDirection = 1;

    float currentRotation = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(transform.position.x);
        print(transform.position.y);
        print(transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        // ✅ MOVEMENT
        transform.position += newPosition * moveDirection * Time.deltaTime * 60f;

        if (transform.position.x > moveLimit || transform.position.x < -moveLimit)
        {
            moveDirection *= -1;
        }

        // ✅ ROTATION
        float rotateAmount = rotationSpeed * Time.deltaTime * rotateDirection;
        transform.Rotate(0, rotateAmount, 0);

        currentRotation += rotateAmount;

        if (currentRotation > rotationLimit || currentRotation < -rotationLimit)
        {
            rotateDirection *= -1;
        }
    }
}
