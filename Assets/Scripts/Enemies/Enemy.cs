// <header>
// Description:  Generic Base Enemy Script for all enemies.
// Created By  : Brett Penney   (Brett.Penney@hotmail.com)
// Created On  : 2022/10/20
// Modified By : 
// Modified On : 
// Modification Note:
// Other Notes:
// </header>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{

	#region Static and Private variables/Fields/Properties
	private GameObject playerObject = null;


	#endregion



	#region Public/Inspector variables
	 public int health;
	 public float movementSpeed;
     public int attackDamage;
	 public float attackSpeed;
	 public float attackRange;
	 public float minDistance; // We could have a set distance to keep the enemies apart from eachother to prevent overlapping of the 3D models.
	 public float maxDistance;  // We could have a set distance to keep the enemies apart from the player to prevent overlapping of the 3D models.
	 public GameObject player;

	#endregion



	#region Private Methods - Unity methods
	
	void Awake()
	{

	}

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (playerObject == null)
			playerObject = GameObject.FindGameObjectWithTag("Player"); //Allows the enemy to find the player location.
	}
	void EnemyDistance()
	{
	
		// Write code that prevents 3D models of enemies from overlapping. So that the player can see what all the enemies are doing.

	}
	void BetweenPlayerAndEnemyDistance()
    {
		
		// Write code that prevents 3D models of enemies from overlapping with the player. So that the player can see what all the enemies are doing.
		
	}

	/*private void avoidOverlap(Enemy other)
	{
		//Working on seperating the models from overlapping.
		if (this.x == other.x)
		{ //or in some radius of this
			this.renderx += 3; //renderx is the position where it is rendered
		}
	}*/


	#endregion



	#region Private Methods

	#endregion



	#region Public methods

	#endregion

}