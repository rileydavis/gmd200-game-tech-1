// © Copyright 2018, 2019 Jonathan Ferguson and Joe Manley
// 
// This file is part of VerticalShooterTutorials.
// 
// VerticalShooterTutorials is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// VerticalShooterTutorials is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with VerticalShooterTutorials.  If not, see <https://www.gnu.org/licenses/>.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    float xMove = 10f;
    float xSpeed = 10f;
    float ySpeed = 5f;
    float yMove = 10f;
    float boundsLeft = -2.1f;
    float boundsRight = 2.1f;
    float boundsUp = -2f;
    float boundsDown = -4.45f;
    Rigidbody2D rb;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }
    void FixedUpdate()
    {
        Move();
        CheckBounds();
    }

    void CheckInput()
    {
        xMove = Input.GetAxis ("Horizontal") * xSpeed;
        yMove = Input.GetAxis ("Vertical") * ySpeed;
    }

    void Move()
    {
        Vector2 newVelocity = new Vector2(xMove, yMove);
        rb.velocity = newVelocity;
    }

    void CheckBounds()
    {
    Vector2 maxPosX;
    Vector2 maxPosY;
         //Horizontal
        if (transform.position.x < boundsLeft)
        {
            maxPosX = new Vector2(boundsLeft, transform.position.y);
            transform.position = maxPosX;
        }
        else if (transform.position.x > boundsRight)
        {
            maxPosX = new Vector2(boundsRight, transform.position.y);
            transform.position = maxPosX;
        }
        //Vertical
        if (transform.position.y < boundsDown)
        {
            maxPosY = new Vector2(transform.position.x, boundsDown);
            transform.position = maxPosY;
        }
        else if (transform.position.y > boundsUp)
        {
            maxPosY = new Vector2(transform.position.x, boundsUp);
            transform.position = maxPosY;
        }
    }
}
