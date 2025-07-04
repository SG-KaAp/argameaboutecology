using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class BottleRecognition : MonoBehaviour
{
    private ARTrackedImageManager _trackedImageManager;

    public GameObject bottlePrefab;

    void Start()
    {
        _trackedImageManager = FindObjectOfType<ARTrackedImageManager>();
        _trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var trackedImage in eventArgs.added)
        {
            if (trackedImage.referenceImage.name == "Bottle")
            {
                Instantiate(bottlePrefab, trackedImage.transform.position, Quaternion.identity);
                if (GUI.Button(new Rect(10, 10, 200, 50), "Нажми меня!"))
                {
                    // Действие, которое произойдет, когда кнопка будет нажата
                    Debug.Log("Кнопка была нажата!");
                }
            }
        }
    }
}
