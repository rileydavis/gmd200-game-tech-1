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

public class EnemyCollision : MonoBehaviour
{

    public GameObject explosionPrefab;
    
    int damage = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);

        //GameManager.singleton.UpdateHealth(damage); //how can this call be restricted to only be damaged by lasers?

        //Destroy(gameObject); //note that this will actually destroy the object. Watch it in the Hierarchy.
        //how to get the enemies to respawn? Here is a way that is consistent with setActive, but scaling the number of enemies becomes a problem too.
        gameObject.SetActive(false); //set SetActive to false (deactivating enemies)
        GameManager.singleton.UnlistEnemy(gameObject); //remove enemy reference from activeEnemyList (that lives in the singleton GameManager object)


    }
}
