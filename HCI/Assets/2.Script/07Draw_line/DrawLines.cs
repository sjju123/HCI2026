using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class DrawLines : MonoBehaviour
{
    public LineSettings lineSettings;
    public Camera arCam;

    ARPlaneManager arPlaneManager;
    bool initialized = false;
    bool canDraw = false;
    bool isStarting = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        arPlaneManager = GetComponent<ARPlaneManager>();
        arPlaneManager.planeChanged = PlaneChanged;
    }
    void PlaneChanged(ARPlanesChangedEventArgs args)
    {
        if (initialized)
        {
            initialized = true;
        }
    }

    public void AllowDraw(bool isAllow)
    {
        if (!initialized) return;

        canDraw = isAllow;
        if (canDraw) isStarting = true;
    }
    // Update is called once per frame
    void Update()
    {
        DrawLine();
    }
    void DrawLine()
    {
        if (!initialized) return;
        if (!canDraw) return;
    }
}
