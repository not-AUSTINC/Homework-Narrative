using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSceneTransport2D : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger touched: " + other.gameObject.name + " | Tag: " + other.tag);
        CheckAndLoad(other.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name + " | Tag: " + collision.gameObject.tag);
        CheckAndLoad(collision.gameObject);
    }

    private void CheckAndLoad(GameObject target)
    {
        if (target.CompareTag("Finish"))
        {
            Debug.Log("Finish tag matched! Attempting to load Treasure Room...");
            SceneManager.LoadScene("Treasure Room");
        }
    }
}
