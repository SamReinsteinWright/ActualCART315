using UnityEngine;
using UnityEngine.SceneManagement;

public class Barn : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Paddle")) // Ensure your player GameObject is tagged "Paddle"
        {
            SceneManager.LoadScene("YouWinScene"); // This must match the name of your win scene
        }
    }
}
