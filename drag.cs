using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    Vector3 cubeScreenPos;
    Vector3 offset;
    

    void Start()
    {
        
        StartCoroutine(OnMouseDown());
    }


    IEnumerator OnMouseDown()
    {
        
        //1.screen position
        cubeScreenPos = Camera.main.WorldToScreenPoint(transform.position);

        //2.migration calculation
        //position of the mouse
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cubeScreenPos.z);
        //turn into global position
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        offset = transform.position - mousePos;
        //3. obj move with mouse
        while (Input.GetMouseButton(0))
        {
            //2D position of mouse--3D position
            Vector3 curMousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cubeScreenPos.z);
            //mouse position-global position
            curMousePos = Camera.main.ScreenToWorldPoint(curMousePos);

            //obj position
            transform.position = curMousePos + offset;

            if (transform.position.y < -0.023) 
            {
                
                transform.position= new Vector3(curMousePos.x + offset.x, -0.023f, curMousePos.z + offset.z); ;
            }
            yield return new WaitForFixedUpdate(); 
        }
    }
}