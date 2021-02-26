using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables

    public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;

	CharacterController2D controller;
	Animator animator;

    #endregion


    private void Start()
	{
		controller = GetComponent<CharacterController2D>();
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetTrigger("Jump");
		}
	}

	void FixedUpdate()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}
}
