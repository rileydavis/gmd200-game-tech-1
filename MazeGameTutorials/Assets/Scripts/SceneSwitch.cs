// © Copyright 2018, 2019 Jonathan Ferguson and Joe Manley
// 
// This file is part of MazeGameTutorials.
// 
// MazeGameTutorials is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// MazeGameTutorials is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with MazeGameTutorials.  If not, see <https://www.gnu.org/licenses/>.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string targetSceneName; 

    // Update is called once per frame
    void Update()
    {
        CheckStart();
    }

    void CheckStart()
    {
        if (Input.GetMouseButtonDown (0)) 
        {
            //Change the scene name depending on which script you are on.
            //Note that this will require that each SceneManager has a string
            //typed into the Unity Inspector for sceneName.
            SceneManager.LoadScene (targetSceneName);
        }
    }
}
