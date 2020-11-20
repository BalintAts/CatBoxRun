using UnityEngine;
using System.Collections;

public class Cat_Controller : MonoBehaviour 
{
	public bool grounded = true;
	private bool doubleJump = false;
	public bool isDead = false;
	private bool groundedB1;
	private bool groundedB2;
	public Transform groundCheck;
	public Transform groundCheck2;
	public Transform deadCheck;
	public Transform deadCheck2;
	public float groundCheckRadius;
	public LayerMask whatisground;
	public AudioClip[] jump_clip;
	public AudioClip[] eat_clip;
	public AudioClip dead_clip;
	public GameObject score;
	private Score_Controller score_controller;
	public GameObject Variable;
	private Variable_Controller variable;
	private Rigidbody2D rigid;
	private Animator anim;
	public int i;
	
	void Start()
	{
		variable = Variable.GetComponent<Variable_Controller>();
		score_controller = score.GetComponent<Score_Controller>();
		rigid = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
	void Update()
	{
		if (!variable.GameRunning)
		{
			return;
		}
		if (grounded)
		{
			doubleJump = false;
		}
		if (isDead)
		{
			anim.SetInteger("AnimState",2);
			AudioSource.PlayClipAtPoint(dead_clip, transform.position);	
			variable.GameRunning = false;
			i = 0;
			return;
		}
		isDead  = Physics2D.OverlapCircle(deadCheck.position,groundCheckRadius,whatisground);
		if (isDead)
		{
			return;
		}
		isDead  = Physics2D.OverlapCircle(deadCheck2.position,groundCheckRadius,whatisground);	
		if (isDead)
		{
			return;
		}
		groundedB1 = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,whatisground);
		groundedB2 = Physics2D.OverlapCircle(groundCheck2.position,groundCheckRadius,whatisground);
		grounded = (groundedB1 | groundedB2);
		rigid.gravityScale = variable.getGravity();
	}
	public bool getDead()
	{
		return isDead;
	}
	public void Jump()
	{
		if (!variable.GameRunning)
		{
			return;
		}
		if (grounded)
		{
			rigid.velocity = new Vector2(rigid.velocity.x, 0);
			rigid.AddForce(new Vector2(0f, variable.getJump()),ForceMode2D.Impulse);
			int random = Random.Range(0,5);
			AudioSource.PlayClipAtPoint(jump_clip[random], transform.position);
		}else
		{
			if (!doubleJump)
			{
				doubleJump = true;
				rigid.velocity = new Vector2(rigid.velocity.x, 0);
				rigid.AddForce(new Vector2(0f, variable.getJump()),ForceMode2D.Impulse);
				int random = Random.Range(0,5);
				AudioSource.PlayClipAtPoint(jump_clip[random], transform.position);
			}
		}
    }
	
	void OnTriggerEnter2D(Collider2D coll) 
	{
        if (coll.gameObject.tag == "Mouse")
		{
			int random = Random.Range(0,4);
			score_controller.scoreIncrease();
			AudioSource.PlayClipAtPoint(eat_clip[random], transform.position);
			anim.Play("Cat_Eat");
			
		}
    }
}
