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
            if (child.gameObject.activeSelf && !child.CompareTag("Logo"))
            {
                child.gameObject.SetActive(false);
            }
            else
            {
                child.gameObject.SetActive(true);
            }
        }
    }

    public void fileClick(GameObject file)
    {
        file.gameObject.SetActive(true);
    }

    public void fileEnter(GameObject file)
    {
        Debug.Log("Something has enter" + file.gameObject.name + "!");
        //file.gameObject.GetComponent<Animator>().SetBool("isEnter",true);
        file.gameObject.transform.localScale = new Vector3(1.15f, 1.15f, 1.15f);
    }

    public void fileExit(GameObject file)
    {
        Debug.Log("Something has exit" + file.gameObject.name + "!");
        //file.gameObject.GetComponent<Animator>().SetBool("isEnter", false);
        file.gameObject.transform.localScale = new Vector3(1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
