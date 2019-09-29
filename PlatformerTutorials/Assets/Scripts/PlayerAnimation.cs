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

public class PlayerAnimation : MonoBehaviour
{
    Rigidbody2D myRigidbody2D;
    Animator myAnimator;
    SpriteRenderer mySpriteRenderer;
    bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myAnimator = gameObject.GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckAnimation();
        CheckFlip();
    }

    void CheckAnimation()
    {
        myAnimator.SetFloat("xMove", Mathf.Abs(myRigidbody2D.velocity.x));
    }

    void CheckFlip()
    {
        if (facingRight && myRigidbody2D.velocity.x < -0.1)
        {
            Flip();
        }
        else if (!facingRight && myRigidbody2D.velocity.x > 0.1)
        {
            Flip();
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        mySpriteRenderer.flipX = !mySpriteRenderer.flipX;
    }
}
