using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float speed = 500f;
	public float jump = 1750f;
	public float maxSpeed = 10;
	//public bool ground;
	private Rigidbody2D RB2;
    private bool facingRight;
    private Animator myAnimator;
    private float distToGround;
	
    // Use this for initialization
	void Start () {
		RB2 = gameObject.GetComponent<Rigidbody2D> ();
        facingRight = true;
        myAnimator = GetComponent<Animator>();
        distToGround = GetComponent<Collider2D>().bounds.extents.y;
    }

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump")&& isGrounded()){
			RB2.AddForce(Vector2.up * jump);
		}
	}

	void FixedUpdate(){
		float move = Input.GetAxis ("Horizontal");
		RB2.AddForce ((Vector2.right * speed) *move);

		if (RB2.velocity.x > maxSpeed) {
			RB2.velocity = new Vector2 (maxSpeed, RB2.velocity.y);
		}

		if (RB2.velocity.x < -maxSpeed) {
			RB2.velocity = new Vector2 (-maxSpeed, RB2.velocity.y);
		}

        Flip(move);
        myAnimator.SetFloat("speed", Mathf.Abs(move));

    }
    

    private void Flip(float horizontal)
    {
        if(horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }

    private bool isGrounded() {

        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        collider.enabled = false;
        RaycastHit2D hit = Physics2D.Raycast(transform.position,Vector2.down,distToGround + 0.1f);
        collider.enabled = true;

        return hit.collider && hit.collider.tag == "Floor";
    }
}
