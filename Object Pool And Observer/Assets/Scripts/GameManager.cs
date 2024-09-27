using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public void SwapScene()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (sceneIndex == 0)
            SceneManager.LoadScene(1);
        else if (sceneIndex == 1)
            SceneManager.LoadScene(0);
    }
}
