using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Client.UI.Menu
{
    public class MenuLogic : MonoBehaviour
    {
        public void LoadScene(string sceneName) => SceneManager.LoadScene(sceneName);
        public void ApplicationQuit() => Application.Quit();
    }
}