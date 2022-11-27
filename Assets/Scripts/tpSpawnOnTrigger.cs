using UnityEngine;
using UnityEngine.SceneManagement;

public class tpSpawnOnTrigger : MonoBehaviour
{
    public GameObject Player;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}