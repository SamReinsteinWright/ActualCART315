using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScenes : MonoBehaviour
{
    public void GoToGameplayScene()
    {
        SceneManager.LoadScene("GameplayScene");
    }    
}
