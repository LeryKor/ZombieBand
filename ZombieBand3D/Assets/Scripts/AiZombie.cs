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
    public Rigidbody2D rb;
    private Vector2 moveZombie;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        _distance = Vector3.Distance(target.transform.position, gameObject.transform.position);
        if(_distance <= _minDistance)
        {
            animator.SetBool("Near", true);
        }
        if(_distance > _minDistance)
        {
            moveZombie = new Vector2(transform.position.x + speed, transform.position.y);
            rb.MovePosition(rb.position + moveZombie * Time.fixedDeltaTime);
            animator.SetBool("Near", false);
        }
    }
  
}
