using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spark : MonoBehaviour
{
    public GameObject shine;
    private float shake;
    private MeshRenderer shineshake;


    //Repete();   <-This is the call in the function for update.

    void Start()
    {
        shineshake = shine.GetComponent<MeshRenderer>();
    }
    void Update()
    {
        
      shake += Time.deltaTime;
        if( shake%1>0.5f)
        {
            shineshake.enabled = true;
        }
        else
        {
            shineshake.enabled = false;
        }

    }
}