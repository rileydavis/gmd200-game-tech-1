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

public class MoveLaser : MonoBehaviour
{

    float laserLife = 60f;
    float lifeCount = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * 500);
    }

    // Update is called once per frame
    void Update()
    {
        CheckLife();
    }

    void CheckLife()
    {
        lifeCount++;
        if (lifeCount == laserLife)
        {
            Destroy(gameObject);
        }
    }
}
