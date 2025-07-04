using UnityEngine;
using UnityEngine.UI;

public class AndroidExitButton : MonoBehaviour
{
    [Tooltip("Кнопка для выхода из игры")]
    public Button exitButton;

    void Start()
    {
        if (exitButton == null)
        {
            exitButton = GetComponent<Button>();
        }
        
        if (exitButton != null)
        {
            exitButton.onClick.AddListener(ExitGame);
        }
    }

    public void ExitGame()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            Application.Quit();
        }
        else if (Application.isEditor)
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }
        else
        {
            Application.Quit();
        }
    }
}