using UnityEngine;
using System.Collections;


public class FireBreathScript : MonoBehaviour {

	public Rigidbody Torch;
	public float speed = 10f;
	
	private void FireTorch () {
		Rigidbody TorchClone = (Rigidbody) Instantiate(Torch, transform.position, transform.rotation);
		TorchClone.velocity = transform.forward * speed;
		
		// You can also acccess other components / scripts of the clone
		///TorchClone.GetComponent<MyRocketScript>().DoSomething();
	}

	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			FireTorch();
		}
	}
}


	