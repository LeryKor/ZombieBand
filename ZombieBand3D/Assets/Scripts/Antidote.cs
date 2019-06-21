using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Antidote : MonoBehaviour
{ public Text text;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
        if (collision = GameObject.FindWithTag("Player").GetComponent<Collider>())
                {
            text.text = "Вы здоровы!";
            Destroy(this.gameObject);
               }
    }

}
