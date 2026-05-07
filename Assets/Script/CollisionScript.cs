using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public int gameObjects = 0;
    public int totalgameObject = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObjects++;
            Debug.Log("Collected! Total: " + gameObjects);

            Destroy(gameObject);
        }

    }
}