using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitrabbit : MonoBehaviour
{
    public Animator rabanim;
    // Start is called before the first frame update
    void Start()
    {
        rabanim.SetBool("isdead", false);
    }

    // Update is called once per frame
    
    void OnCollisionEnter3D(Collision coll)
    {

        if (coll.gameObject.tag == "hit")
        {
            Debug.Log("pound");
            rabanim.SetBool("isdead", true);

        }
    }
}