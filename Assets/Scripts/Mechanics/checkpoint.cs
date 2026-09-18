using UnityEngine;

public class checkpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject.Find("SpawnPoint").transform.position = transform.position;
            Destroy(gameObject.GetComponent<checkpoint>());
        }
    }
}
