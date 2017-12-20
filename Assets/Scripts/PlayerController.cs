using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float jumpForce;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;

    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private Rigidbody2D rigid;
    public bool ground;

    private Animator animator;
	public GameManager manager;
	public ScoreManager score;

    // Use this for initialization
    void Start () {
        // Get the rigid body component
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        // Checking if player is touching the ground
        ground = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);

        if (Input.GetKey(left)){
            rigid.velocity = new Vector2(-speed, rigid.velocity.y);
        }
        else if (Input.GetKey(right))
        {
            rigid.velocity = new Vector2(speed, rigid.velocity.y);
        }
        else
        {
            rigid.velocity = new Vector2(0, rigid.velocity.y);
        }

        if(Input.GetKeyDown(jump) && ground)
        {
            rigid.velocity = new Vector2(rigid.velocity.x, jumpForce);
        }

        if(rigid.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (rigid.velocity.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        animator.SetFloat("Speed", rigid.velocity.x);
        animator.SetBool("Grounded", ground);
    }

	void OnCollisionEnter2D(Collision2D catcher){
		if (catcher.gameObject.tag == "Catcher") {
			manager.Restart ();
			score.Hurt ();
		}
	}
}
