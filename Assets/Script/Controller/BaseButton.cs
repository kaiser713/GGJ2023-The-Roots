using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BaseButton : MonoBehaviour
{
    public bool isOpen = false;

    void Start()
    {

    }

    public void ListClick(GameObject prefab)
    {
        Debug.Log("点击事件: 展示子資料夾");
        //GameObject originalGameObject = Instantiate(prefab);
        for (int i = 0; i < prefab.transform.childCount; i++)
        {
            GameObject child = prefab.transform.GetChild(i).gameObject;
            //Do something with child
            if (child.gameObject.activeSelf)
            {
                child.gameObject.SetActive(false);
            }
            else
            {
                child.gameObject.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
