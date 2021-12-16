using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figure : MonoBehaviour
{
    [SerializeField] new GameObject gameObject;
    private ObjectСhange objectСhange;

    void Start()
    {
        objectСhange = FindObjectOfType<ObjectСhange>();

        objectСhange.destroyObj += () => Destroy(gameObject); ;
    }

}
