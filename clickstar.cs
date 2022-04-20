using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickstar : MonoBehaviour
{
    

    public int blood = 0;

    public GameObject blood0;
    public GameObject blood1;
    public GameObject blood2;
    public GameObject blood3;

    // Start is called before the first frame update
    void Start()
    {
        

        blood0.GetComponent<SpriteRenderer>().enabled = true;
        blood1.GetComponent<SpriteRenderer>().enabled = false;
        blood2.GetComponent<SpriteRenderer>().enabled = false;
        blood3.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame

    void OnMouseDown()
    {
        
            Debug.Log("blood");
           

            blood++;
        

        if (blood == 0)
        {
            Debug.Log("blood0");

            blood0.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (blood == 1)
        {
            Debug.Log("blood1");
            blood1.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (blood == 2)
        {
            Debug.Log("blood2");

            blood2.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (blood == 3)
        {
            Debug.Log("blood3");
            blood3.GetComponent<SpriteRenderer>().enabled = true;
        }

        
    }



}
