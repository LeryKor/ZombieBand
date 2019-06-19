using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinalScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if( collision = GameObject.FindWithTag("Player").GetComponent<Collider2D>())
        { 
            SceneManager.LoadScene("SecondScene");
        }
    }
}
