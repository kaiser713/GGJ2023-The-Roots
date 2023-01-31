using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileClose : MonoBehaviour
{
    public GameObject closeFile;

    void Start()
    {
        
    }

    public void FileExit()
    {
        closeFile.SetActive(false);
    }
}
