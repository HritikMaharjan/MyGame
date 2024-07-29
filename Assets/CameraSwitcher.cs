using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera;
    public Camera secondCamera;
    public float switchTime = 5.0f; // Time after which to switch cameras

    void Start()
    {
        // Ensure only the main camera is active at the start
        mainCamera.gameObject.SetActive(true);
        secondCamera.gameObject.SetActive(false);

        // Schedule the camera switch
        Invoke("SwitchToSecondCamera", switchTime);
    }

    void SwitchToSecondCamera()
    {
        mainCamera.gameObject.SetActive(false);
        secondCamera.gameObject.SetActive(true);
    }
}
