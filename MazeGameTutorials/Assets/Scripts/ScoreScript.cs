﻿// © Copyright 2018, 2019 Jonathan Ferguson and Joe Manley
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
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    int score = 0;

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString ();
    }
}
