using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {


	private Vector3 moveDirection = Vector3.zero;
	public float speed = 30.0f;

	void Start() {
	}


	void Update()
	{
		CharacterController controller = GetComponent<CharacterController>();
		
		moveDirection = transform.TransformDirection(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		moveDirection *= speed;
		
		controller.Move(moveDirection * Time.deltaTime);
	}


}