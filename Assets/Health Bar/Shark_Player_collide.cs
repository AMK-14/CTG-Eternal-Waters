using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark_Player_collide : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);

		//Set the tag of this GameObject to Player
        gameObject.tag = "Player";
	}



	

	private void OnTriggerEnter2D(Collider2D collider){
		TakeDamage(20);
		Debug.Log("Triggered by Shark");

		
	}



	

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
}
