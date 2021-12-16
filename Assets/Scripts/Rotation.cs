using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    private Quaternion originRotation;
    private float angleHorizontal;
    private float angleVertical;

    [SerializeField]private float mouseSens = 10;

    private void Start()
    {
        originRotation = transform.rotation;
    }

    private void FixedUpdate()
    {
        RotationFigure();
    }

    private void RotationFigure()
    {
        if (Input.GetButton("Fire1"))
        {
            angleHorizontal += Input.GetAxis("Mouse X") * mouseSens;
            angleVertical += Input.GetAxis("Mouse Y") * mouseSens;

            Quaternion rotationY = Quaternion.AngleAxis(angleHorizontal, Vector3.up);
            Quaternion rotationX = Quaternion.AngleAxis(-angleVertical, Vector3.right);

            transform.rotation = originRotation * rotationY * rotationX;
        }
    }
}