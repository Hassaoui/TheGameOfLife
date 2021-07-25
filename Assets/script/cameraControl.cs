using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private float targetZoom;
    [SerializeField] private float zoomFactor = 3f;
    [SerializeField] private float ZoomLerpSpeed = 10f;
    [SerializeField] private float maxZoomOut = 90f;


    void Start()
    {
        cam = Camera.main;
        targetZoom = cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        float scrollData;
        scrollData = Input.GetAxis("Mouse ScrollWheel");
        targetZoom -= scrollData * zoomFactor;
        targetZoom = Mathf.Clamp(targetZoom, 9f, maxZoomOut);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, Time.deltaTime * ZoomLerpSpeed);
    }
}
