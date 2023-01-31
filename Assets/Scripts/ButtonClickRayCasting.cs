using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickRayCasting : MonoBehaviour
{
    public Camera mainKamera;
    private RaycastHit raycastHit;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse clicked");
            Ray ray = mainKamera.ScreenPointToRay(Input.mousePosition);
            Debug.Log(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.collider.gameObject.name == "myButton")
                {
                    Debug.Log("yeah!");
                }
            }
        }
    }
}