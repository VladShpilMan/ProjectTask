using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PhotoCapture : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    private string folderPath;

    public void MakeScrenshot()
    {
        folderPath = CreateCatalog();

        StartCoroutine(Screen());
        var screenshotName =
                        "Screenshot_" +
                        System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") +
                        ".png";
        ScreenCapture.CaptureScreenshot(folderPath + screenshotName);
    }

    private string CreateCatalog()
    {
        string path = Application.dataPath;
        string subpath = @"Output/";
        DirectoryInfo dirInfo = new DirectoryInfo(path);
        if (!dirInfo.Exists)
        {
            dirInfo.Create();
        }
        dirInfo.CreateSubdirectory(subpath);
        return path + "/" + subpath;
    }


    IEnumerator Screen()
    {
        canvas.enabled = false;
        yield return new WaitForEndOfFrame(); 
        canvas.enabled = true;
    }

}
