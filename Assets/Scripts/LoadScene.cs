using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] Scene sceneToLoad;

    public void NextScene()
    {
        SceneManager.LoadScene(sceneToLoad.buildIndex);
    }
}
