using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spieler : MonoBehaviour {
    public Rigidbody2D rb;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;

    public Transform Gegner;
    public float gegnerRadius;
    public LayerMask woIstGegner;
    private bool onGegner;

    public float speedMultiplier;
    public float speedIncreaseMilestone;
    private float speedMilestoneCount;

    public float moveSpeed;

	void Start () {
        rb = GetComponent<Rigidbody2D>();	
	}

	void Update () {

        if(transform.position.x > speedMilestoneCount)
        {
            speedMilestoneCount += speedIncreaseMilestone;
            //speedIncreaseMilestone += speedIncreaseMilestone * speedMultiplier;
            moveSpeed = moveSpeed * speedMultiplier;
        }

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        onGegner = Physics2D.OverlapCircle(Gegner.position, gegnerRadius, woIstGegner);

        if (Input.GetMouseButtonDown(0) && onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, moveSpeed + 1);
        }

        if (onGround != true && rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

        if (onGegner == true)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

		
	}
}
