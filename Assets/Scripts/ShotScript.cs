using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {
	public int damge = 1;
	public bool isEnemyShot = false;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
