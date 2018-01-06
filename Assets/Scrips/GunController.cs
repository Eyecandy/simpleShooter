using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {
	
	public GameObject bullet;
	public GameObject bulletSpawn;
	public float fireRate;
	void Start() {
		
	}

	void Update () {
		if (Input.GetMouseButton(0)) {
			fire ();
		}
	}
	private void fire() {
		Instantiate (bullet.transform, bulletSpawn.transform.position, Quaternion.identity);
	}
}
