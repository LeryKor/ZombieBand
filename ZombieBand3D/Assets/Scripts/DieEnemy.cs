using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieEnemy : MonoBehaviour
{
    public void ReactToHit()
    {//метод, вызванный сценарием стрельбы
        StartCoroutine(Die());
        Enemy behavior = GetComponent<Enemy>();
        if (behavior != null)
        {
            
        }
    }

    private IEnumerator Die()
    {
        GetComponent<Animator>().SetBool("Alive", false);
        yield return new WaitForSeconds(10.0f);
        Destroy(this.gameObject);
    }
}
