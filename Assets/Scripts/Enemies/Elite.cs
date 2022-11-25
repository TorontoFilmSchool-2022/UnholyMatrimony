// <header>
// Description:  Elite Script 
// Created By  : Brett Penney   (Brett.Penney@hotmail.com)
// Created On  : 2022/11/25
// Modified By : 
// Modified On : 
// Modification Note:
// Other Notes:
// </header>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Elite : Enemy
{

	#region Static and Private variables/Fields/Properties
	private Vector3 playerPosition;

	#endregion



	#region Public/Inspector variables
	public Transform playerTransform;

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
		if (GameObject.FindGameObjectWithTag("Player"))
		{
			// Allows the enemy to chase the player.
			playerPosition = new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z);
			transform.position = Vector3.MoveTowards(transform.position, playerPosition, movementSpeed);
		}
		if (health <= 0)
		{
			Destroy(gameObject);
		}
	}

	#endregion



	#region Private Methods

	#endregion



	#region Public methods

	#endregion

}