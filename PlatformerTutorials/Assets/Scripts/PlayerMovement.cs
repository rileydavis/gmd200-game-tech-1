// © Copyright 2018, 2019 Jonathan Ferguson and Joe Manley
// 
// This file is part of PlatformerTutorials.
// 
// PlatformerTutorials is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// PlatformerTutorials is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with PlatformerTutorials.  If not, see <https://www.gnu.org/licenses/>.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float xMove = 0f;
    public float xSpeed = 5f;
    public float jumpForce = 700f;
    bool isGrounded = false;
    bool shouldJump = false;
    Rigidbody2D myRigidbody2D;
    public LayerMask ground;
    public Transform groundCheck;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void FixedUpdate()
    {
        Move();
        CheckJump();
        CheckGround();
    }
    void CheckInput()
    {
        xMove = Input.GetAxis("Horizontal") * xSpeed;
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            shouldJump = true;
        }
    }

    void CheckJump()
    {
        if (shouldJump)
        {
            Jump();
        }
    }

    void CheckGround()
    {
        Collider2D col = Physics2D.OverlapCircle(groundCheck.position, 1f, ground);
        if (col == null)
        {
            isGrounded = false;
        }
        else
        {
            isGrounded = true;
        }
    }

    void Jump()
    {
        shouldJump = false;
        myRigidbody2D.AddForce(Vector2.up * jumpForce);
    }

    void Move()
    {
        myRigidbody2D.velocity = new Vector2(xMove, myRigidbody2D.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MovingPlatform")
        {
            transform.parent = collision.transform;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MovingPlatform")
        {
            transform.parent = null;
        }
    }
}
