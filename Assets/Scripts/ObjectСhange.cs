using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectСhange : MonoBehaviour
{
    #region Delegates and Events
    public delegate void DestroyObj();
    public event DestroyObj destroyObj;
    #endregion

    #region Private
    private GameObject[] objects;
    private int numbObj;
    #endregion



    private void Start()
    {
        objects = Resources.LoadAll("Input", typeof(GameObject)).Cast<GameObject>().ToArray();

        Instantiate(objects[0], Vector3.up, Quaternion.identity);
        numbObj = 0;
    }

    public void СhangeNext()
    {
        if (numbObj < objects.Length - 1)
        {
            numbObj++;
            Instantiate(objects[numbObj], Vector3.up, Quaternion.identity);
            destroyObj?.Invoke();
        }
        else
        {
            numbObj = 0;
            Instantiate(objects[numbObj], Vector3.up, Quaternion.identity);
            destroyObj?.Invoke();
        }
    }

    public void СhangeBack()
    {
        if (numbObj > 0)
        {
            numbObj--;
            Instantiate(objects[numbObj], Vector3.up, Quaternion.identity);
            destroyObj?.Invoke();
        }
        else
        {
            numbObj = objects.Length - 1;
            Instantiate(objects[numbObj], Vector3.up, Quaternion.identity);
            destroyObj?.Invoke();
        }
    }
}
