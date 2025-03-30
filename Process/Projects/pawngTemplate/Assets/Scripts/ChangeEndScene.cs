using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeEndScene : MonoBehaviour
{
    public void GoToStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
