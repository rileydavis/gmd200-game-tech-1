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

public class Enemy : MonoBehaviour
{

    float respawnX;
    float respawnY = 6;

    // Start is called before the first frame update
    void Start()
    {
        respawnX = transform.position.x;
    }

    public void Respawn()
    {
        gameObject.SetActive(true);
        Vector2 newPos = new Vector2(respawnX, respawnY);
        transform.position = newPos;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
    void OnMouseDown()
    {
        Debug.Log("down");
        gameObject.SetActive(false); //set SetActive to false (deactivating enemies)
        GameManager.singleton.UnlistEnemy(gameObject); //remove enemy reference from activeEnemyList (that lives in the singleton GameManager object)
    }


}
