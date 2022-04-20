using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class charactermove : MonoBehaviour
{
    // Start is called before the first frame update
   
    public Transform m_tranform;
    
    public float m_speed = 1.0f;
    
    
    CharacterController m_chaController;

    
    public Transform m_camTransform;
    
    Vector3 m_camRot;
    
    public float m_camHigh = 1.8f;

   
    

    //in case the camera rotates
    public float m_minimumY = -45f;
    public float m_maximumY = 45f;

    
    
    void Start()
    {
        m_tranform = this.transform;
        
        m_chaController = GetComponent<CharacterController>();

        
        m_camTransform = Camera.main.transform;
        m_camTransform.position = m_tranform.TransformPoint(0, m_camHigh, 0);
        m_camTransform.rotation = m_tranform.rotation;
        m_camRot = m_tranform.eulerAngles;
        

    }


    // Update is called once per frame
    void Update()
    {
        Control();
    }


    //the movement of character
    void Control()
    {
        Vector3 moveTo = Vector3.zero;
        moveTo.x = Input.GetAxis("Horizontal") * Time.deltaTime * m_speed;
        moveTo.z = Input.GetAxis("Vertical") * Time.deltaTime * m_speed;
        moveTo.y = 0f;

        m_chaController.Move(m_tranform.TransformDirection(moveTo));
        

        //movement of camera
        float rh = Input.GetAxis("Mouse X");
        float rv = Input.GetAxis("Mouse Y");

         m_camRot.x -= rv;
    

        if (rh <= m_minimumY)
        {
            m_camRot.y = m_minimumY;

        }

        if(rh>= m_maximumY)
        {
            m_camRot.y = m_maximumY;
        }

        else
        {
            m_camRot.y += rh;
        }

        
        m_camTransform.eulerAngles = m_camRot; //camera rotate
        


        Vector3 camrot = m_camTransform.eulerAngles;
        camrot.x = 0;
        camrot.z = 0;
        m_tranform.eulerAngles = camrot; 
        m_camTransform.position = transform.TransformPoint(0, m_camHigh, 0);

       

    }

}



