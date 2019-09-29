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

public class MovePlatform : MonoBehaviour
{

    public GameObject platform; //points to the platform prefab in the MovingPlatform
    //this is what will move, MovingPlatform just stays in position
    public float speed = 5f;// how fast the platform moves
    public Transform[] movePoints;// an array of points that the platform will follow
    Transform currentPoint;//the current point the platform is moving toward
    public int pointIndex = 0;//current index of the current platform
    public bool isLooping = false; //Loop the moving platform?

    // Start is called before the first frame update
    void Start()
    {
        currentPoint = movePoints[pointIndex];
    }

    // Update is called once per frame
    void Update()
    {
        platform.transform.position = Vector2.MoveTowards(platform.transform.position, currentPoint.position, Time.deltaTime * speed);

        if (platform.transform.position == currentPoint.position)
        {
            if (pointIndex < movePoints.Length - 1)
            {
                pointIndex++;
                currentPoint = movePoints[pointIndex];
                Debug.Log(pointIndex);
            }
            else if (isLooping == true)
            {
                pointIndex = 0;
                currentPoint = movePoints[pointIndex];
            }
        }
    }
}
