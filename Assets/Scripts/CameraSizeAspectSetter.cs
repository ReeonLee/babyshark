using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
[RequireComponent(typeof(Camera))]
public class CameraSizeAspectSetter : MonoBehaviour
{
    public float cameraSize = 5f;
    public Vector2 screenSize = new Vector2(1080f, 1920f);

    private Camera m_Camera;
    public Camera Cam
    {
        get
        {
            if (Application.isPlaying == false)
                return GetComponent<Camera>();

            if (m_Camera == null) m_Camera = GetComponent<Camera>();
            return m_Camera;
        }
    }

    private void Update()
    {
        UpdateCameraSize();
    }

    private void OnGUI()
    {
        UpdateCameraSize();
    }

    private void UpdateCameraSize()
    {
        var targetAspect = screenSize.x / screenSize.y;
        var currentAspect = (float)Screen.width / Screen.height;
        //if (currentAspect < targetAspect)
        {
            Cam.orthographicSize = cameraSize * (targetAspect / currentAspect);
        }
        //else
        //{
        //    Cam.orthographicSize = cameraSize;
        //}
    }

}
