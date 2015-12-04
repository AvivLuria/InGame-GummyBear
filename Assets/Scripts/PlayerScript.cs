using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public Vector2 speed = new Vector2 (6, 6);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (speed.x * inputX, speed.y * inputY, 0);
		movement *= Time.deltaTime;

		transform.Translate (movement);

		// Shoting part
		bool shoot = Input.GetButton ("Fire1");
		shoot |= Input.GetButtonDown ("Fire2");

		if (shoot)
		{
			WeaponScript[] weapons = GetComponentsInChildren<WeaponScript>();
			foreach (WeaponScript weapon in weapons) {
			//WeaponScript weapon = GetComponent<WeaponScript>();
				if (weapon != null) {
					weapon.Attack(false);
				}
			}
		}
	}
}