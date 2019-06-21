using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastMusic : MonoBehaviour
{
    public AudioSource so;
    public AudioClip cl;
    // Start is called before the first frame update
    void Start()
    {
        so.PlayOneShot(cl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
