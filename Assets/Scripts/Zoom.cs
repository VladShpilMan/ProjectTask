using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Zoom : MonoBehaviour
{
    private bool zoomFlag;

    [SerializeField] private Camera mainCamera;
    [SerializeField] private Image image;
    

    private void Start()
    {
        zoomFlag = false;
    }

    public void ZoomCamera()
    {
        if (!zoomFlag)
        {
            mainCamera.orthographicSize = 3;
            zoomFlag = !zoomFlag;
            image.sprite = Resources.Load<Sprite>("Sprites/decline");
        }
        else
        {
            mainCamera.orthographicSize = 5;
            zoomFlag = !zoomFlag;
            image.sprite = Resources.Load<Sprite>("Sprites/zoom");
        }
    }
}
