using UnityEngine;
using UnityEngine.SceneManagement;
public class LegacyGUISceneLoader : MonoBehaviour
{
    public void LoadScene(string name) => SceneManager.LoadScene(name);
}