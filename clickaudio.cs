using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickaudio : MonoBehaviour
{
    public Animator clickanim;

    public AudioSource audioSource;
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        clickanim = GetComponent<Animator>();
        clickanim.SetBool("isclick", false);
    }

    // Update is called once per frame

    IEnumerator OnMouseDown()
    {
        Debug.Log("isClick");
        clickanim.SetBool("isclick", true);

        audioSource.clip = audioClip;
        audioSource.Play();

        yield return new WaitForSeconds(2);
        clickanim.SetBool("isclick", false);
    }



}
