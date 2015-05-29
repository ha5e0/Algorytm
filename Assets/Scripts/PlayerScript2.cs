using UnityEngine;
using System.Collections;

public class PlayerScript2 : MonoBehaviour {
	
	public float speed = 10.0f;
	public float rotatespeed = 10.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		float hor = Input.GetAxis ("Horizontal");
		float ver = Input.GetAxis ("Vertical");

		

		transform.Rotate ( Vector3.up * hor * rotatespeed);


		GetComponent<Rigidbody>().MovePosition(transform.position + (transform.forward * ver) * speed * Time.deltaTime);
		
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody>().AddForce(new Vector3(0,300.0f,0));
		}
		
		
		//Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		//GetComponent<Rigidbody>().MovePosition(transform.position + moveDirection * speed * Time.deltaTime);
	}
	
	void FixedUpdate() {
	}
}
