using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiZombie : MonoBehaviour
{
    private float _distance;
    private float _minDistance = 10f;
    public Animator animator;
    public float speed = 20.0f;
    public GameObject target;
    private bool _alive = true;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        target = GameObject.FindWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        _distance = Vector3.Distance(target.transform.position, gameObject.transform.position);
        if (_alive == true)
        {
            if (_distance <= _minDistance)
            {
                if (target.GetComponent<Animator>().GetBool("Strike") == true)
                {
                    animator.SetBool("Kill", true);
                    _alive = false;
                    GetComponent<CapsuleCollider2D>().enabled = false;
                    transform.Translate(0, 2.4f, 0);
                    GetComponent<BoxCollider2D>().enabled = true;
                }
                animator.SetBool("Near", true);
            }
            if (_distance > _minDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
                animator.SetBool("Near", false);
                if (target.transform.position.x > transform.position.x)
                {
                    gameObject.GetComponent<SpriteRenderer>().flipX = false;
                }
                else
                {
                    gameObject.GetComponent<SpriteRenderer>().flipX = true;
                }

            }
        }
    }
  
}
