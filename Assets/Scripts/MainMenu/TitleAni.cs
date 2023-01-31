using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleAni : MonoBehaviour
{
    TMPro.TMP_Text mText;
    string titleNameBefore = "Roots_";
    string titleNameAfter = "Roots";

    void Start()
    {
        mText = gameObject.GetComponent<TMPro.TMP_Text>();
        titleNameBefore = mText.text;
        mText.text = titleNameAfter;
        InvokeRepeating("scriptAnimation1", 0 ,0.6f);
        InvokeRepeating("scriptAnimation2", 0.4f, 0.6f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void scriptAnimation1()
    {
        mText.text = titleNameBefore;
    }
    public void scriptAnimation2()
    {
        mText.text = titleNameAfter;
    }
}
