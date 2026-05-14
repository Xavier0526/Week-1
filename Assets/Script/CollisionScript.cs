using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    GameObject currentCollectible;
    int collCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Collectible")
        {
            currentCollectible = collision.gameObject;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject == currentCollectible)
        {
            currentCollectible = null;
        }
    }

    void OnInteract()
    {
        if(currentCollectible != null)
        {
            CollectibleScript collectible = currentCollectible.GetComponent<CollectibleScript>();

            collCount++;
            
            print("Player has collected " + collCount + " collectibles");
            
            Destroy(currentCollectible);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GoalArea" && collCount >= 3)
        {
            print("Player entered trigger zone with " + collCount + " collectibles");
        }

        if (other.CompareTag("Collectible"))
        {
            currentCollectible = other.gameObject;

            CollectibleScript collectible =
                currentCollectible.GetComponent<CollectibleScript>();

            if (collectible != null)
            {
                collCount += collectible.CollectibleScore;
                Debug.Log("Score: " + collCount);
            }

            Destroy(currentCollectible);
        }
    }

}