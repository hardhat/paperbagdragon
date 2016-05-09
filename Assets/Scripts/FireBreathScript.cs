using UnityEngine;
using System.Collections;


public class FireBreathScript : MonoBehaviour {

	public Rigidbody Torch;
	public float speed = 10f;
    private float distance = 1000.0f;

    private void FireTorch()
    {
        Rigidbody TorchClone = (Rigidbody)Instantiate(Torch, transform.position, transform.rotation);
        RaycastHit hit;
        float damage = 1;
        TorchClone.velocity = transform.forward * speed;

        Destroy(TorchClone, 3.0f);

        // You can also acccess other components / scripts of the clone
        ///TorchClone.GetComponent<MyRocketScript>().DoSomething();
        ///
        Vector3 direction = transform.TransformDirection(Vector3.forward);

        bool result = Physics.Raycast(transform.position, direction, out hit, distance);
        if(result)
        {
            Debug.DrawLine(transform.position, hit.point, Color.cyan);

            // - send damage to object we hit - \\
            hit.collider.SendMessageUpwards("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
            Debug.Log("Hit " + hit.collider.gameObject.name);
        }
    }

	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			FireTorch();
		}
	}
}
