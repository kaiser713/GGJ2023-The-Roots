using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClick : MonoBehaviour
{
    public GameObject dialog;

    private void End1()
    {
        Debug.Log("Entering Ending 1");
        TextAsset ending = Resources.Load<TextAsset>("End1") as TextAsset;
        dialog.GetComponent<DialogSystem>().GetTextFromFile(ending);
    }
    private void End2()
    {
        Debug.Log("Entering Ending 2");
        TextAsset ending = Resources.Load<TextAsset>("End2") as TextAsset;
        dialog.GetComponent<DialogSystem>().GetTextFromFile(ending);
    }
    private void End3()
    {
        Debug.Log("Entering Ending 3");
        TextAsset ending = Resources.Load<TextAsset>("End3") as TextAsset;
        dialog.GetComponent<DialogSystem>().GetTextFromFile(ending);
    }
    private void TestingEnding(string str)
    {
        Debug.Log(str);
    }

    public void clickEvent(string str)
    {
        switch (str)
        {
            case ".Root/data/Submit folder/Classified":
                End1();
                break;
            case ".Root/data/Photo/meme1.png":
                End2();
                break;
            case ".Root/data/Photo/meme2.png":
                End2();
                break;
            case ".Root/data/Photo/meme3.png":
                End2();
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
