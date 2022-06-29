using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMissle : MonoBehaviour
{
	public GameObject projectile; //reference to the gameobject the enemy will shoot

	public Transform projectileSpawn; //reference to where the projectile will spawn...

	float nextFire = 1.5f;
	float currentTime = 0.0f;

	// Use this for initialization
	void Start()
	{
		projectileSpawn = this.gameObject.transform;
	}

	// Update is called once per frame
	void Update()
	{
		PlayerShootMissle();
	}

	public void PlayerShootMissle()
	{
		currentTime += Time.deltaTime;
		if (currentTime > nextFire)
		{
			nextFire += currentTime;

			Instantiate(projectile, projectileSpawn.position, Quaternion.identity); //FIRE!

			nextFire -= currentTime;
			currentTime = 0.0f;
		}
	}
}
