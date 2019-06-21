using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    public float speed = 0.25f;
    public AudioSource au;
    public AudioClip clip;
    void Start()
    {
        au.PlayOneShot(clip);
            }

    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed; 
        float deltaZ = Input.GetAxis("Vertical") * speed;
        transform.Translate(deltaX, 0, deltaZ);
        
    }
        

}
