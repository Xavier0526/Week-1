using UnityEngine;

public class Green : MonoBehaviour
{
    public int gameObjects = 0;
    public int totalgameObject = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Green")
        {
            if (gameObjects >= totalgameObject)
            {
                Debug.Log("All collectibles collected!");
            }
            else
            {
                Debug.Log("Collect all collectibles first!");
            }
        }
    }

    // Update is called once per frame

}
