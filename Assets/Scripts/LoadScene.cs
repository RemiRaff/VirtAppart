using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] string OtherSceneName;      

    public void NextScene()
    {
        SceneManager.LoadScene(OtherSceneName);
    }
}
