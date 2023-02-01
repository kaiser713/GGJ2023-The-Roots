using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClick : MonoBehaviour
{
    private void End1()
    {
        Debug.Log("Hello World!");
    }
    private void End2()
    {
        Debug.Log("Hello Tom");
    }
    private void End3()
    {
        Debug.Log("PPP");
    }
    private void TestingEnding(string str)
    {
        Debug.Log(str);
    }

    public void clickEvent(string str)
    {
        switch (str)
        {
            case "69":
                End1();
                break;
            case "Tom":
                End2();
                break;
            case "111":
                End3();
                break;
            default :
                TestingEnding(str);
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
