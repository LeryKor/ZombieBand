using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public Transform target;
    private float _distance;
    private float _minDistance = 2.5f;
    public Animator anim;
    public PlayerCharacter player;
    public int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
        anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.localRotation, Quaternion.LookRotation(target.position - transform.position), speed * Time.deltaTime);
        _distance = Vector3.Distance(target.transform.position, gameObject.transform.position);
        if (_distance > _minDistance)
        {
            anim.SetBool("attack", false);
        }
    else
        {
            anim.SetBool("attack", true);
            if (anim.GetBool("Alive") == true)
            {
                player.Hurt(damage);
            }
        }
        
  
    }
}
