using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
	
	public float speed;
	public float aliveTime;
	void FixedUpdate () {
		this.transform.Translate(Vector3.forward * Time.deltaTime *10);
		aliveTime -= Time.deltaTime * 1;
		if (aliveTime <= 0) {
			Destroy (this.gameObject);
		};
	}
}
