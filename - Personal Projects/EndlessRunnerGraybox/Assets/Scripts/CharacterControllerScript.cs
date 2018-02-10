using UnityEngine;
using System.Collections;

public class CharacterControllerScript : MonoBehaviour {

	//Movement
	[SerializeField] private float maxSpeed = 5f;
	private bool facingRight = true;
	private Rigidbody2D rigid;

	//animations
	private Animator anim;

	//fall animation & jump
	private bool onGround = false;
	private Transform groundCheck;
	private float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	[SerializeField] private float jumpForce = 150f;

	//dubble jump
	private bool doubleJump = false;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();

		//animations
		anim = GetComponent<Animator>();

		groundCheck = GameObject.FindGameObjectWithTag ("GroundCheck").transform;
	}
	
	// FixedUpdate is called once per physicsupdate
	void FixedUpdate () {

		//fall Animations & jump
		onGround = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
		// checks for overlaps and returns boolean
		anim.SetBool("Ground",onGround);

		//dubbeljump
		if(onGround){
			doubleJump = false;
		}

		//movement
		if(!onGround){ 	//CANNOT MOVE WHILE IN AIR
			return;		//CANNOT MOVE WHILE IN AIR
		}				//CANNOT MOVE WHILE IN AIR
		float move = Input.GetAxis ("Horizontal_P1");

		//animations
		anim.SetFloat ("Speed", Mathf.Abs(move));

		//movement
		rigid.velocity = new Vector2 (move*maxSpeed, rigid.velocity.y);

		//flip the character
		if(move > 0 && !facingRight){
			Flip ();
		} else if (move < 0 && facingRight){
			Flip ();
		}
	}

	//Jump (update for better input detect)
	void Update(){
		if((onGround || !doubleJump) && Input.GetButton("Jump_P1")){
			anim.SetTrigger ("Jump");
			rigid.AddForce (new Vector2(0,jumpForce));
			if(!doubleJump && !onGround){
				doubleJump = true;
			}
		}
	}

	//flip the character 
	void Flip (){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
