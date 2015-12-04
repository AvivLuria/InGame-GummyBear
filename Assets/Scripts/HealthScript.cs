using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	// Starting hp
	public int HP = 2;

	public bool isEnemy = true;

	void OnTriggerEnter2D (Collider2D collider) {
		ShotScript shot = collider.gameObject.GetComponent<ShotScript> ();

		if (shot != null) {
			if (shot.isEnemyShot != isEnemy) {
				HP -= shot.damge;
				Destroy(shot.gameObject);

				// Kill the enemy
				if (HP <= 0) {
					Destroy(gameObject);
				}
			}
		}
	}
}
