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
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        _distance = Vector3.Distance(target.transform.position, gameObject.transform.position);
        if (_distance <= _minDistance)
        {
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
