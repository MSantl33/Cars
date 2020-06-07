using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolaAuta : MonoBehaviour {

	public float carSpeed;
	public float MaxPos=2.3f;
	Vector3 position;
	public Rezultat UI;

	// Use this for initialization
	void Start () {
		position = transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
		position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;
		position.x=Mathf.Clamp(position.x,-2.4f,2.4f);
		transform.position = position;

		position.y += Input.GetAxis ("Vertical") * carSpeed * Time.deltaTime;
		position.x=Mathf.Clamp(position.x,-4f,3.2f);
		transform.position = position;

	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "ProtivnickiAuto") {
			Destroy (gameObject);
			UI.GameOverActivated ();
		}
	}
}
