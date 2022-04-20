using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickbush : MonoBehaviour
{
    public Animator clickanim;
    public GameObject rabbit;
    public GameObject star;
    public GameObject outcome;
    // Start is called before the first frame update
    void Start()
    {
        clickanim = GetComponent<Animator>();
        clickanim.SetBool("isclick", false);
        rabbit.GetComponent<Animator>().enabled = false;
        
        star.SetActive(false);
        outcome.SetActive(false);
    }

    // Update is called once per frame

    IEnumerator OnMouseDown()
    {
        Debug.Log("isClick");
        clickanim.SetBool("isclick", true);
        rabbit.GetComponent<Animator>().enabled = true;
       
        star.SetActive(true);

        yield return new WaitForSeconds(2);

        Debug.Log("youfoundit");
        outcome.SetActive(true);

        yield return new WaitForSeconds(2);
        outcome.SetActive(false);

    }



}
