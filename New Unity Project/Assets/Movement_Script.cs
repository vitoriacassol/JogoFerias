using UnityEngine;
using System.Collections;

public class asdad : MonoBehaviour {

	public float Speed;
	// Use this for initialization
	void Start () {

	//	RB2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.A)) {
			Vector3 Position = this.transform.position;
			Position.x -= 0.01f;
			this.transform.position = Position;
		}  if (Input.GetKey (KeyCode.D)) {
			Vector3 Position = this.transform.position;
			Position.x += 0.01f;
			this.transform.position = Position;
		}  if (Input.GetKey (KeyCode.W)) {
			Vector3 Position = this.transform.position;
			Position.y += 0.01f;
			this.transform.position = Position;
		}
		 if (Input.GetKey (KeyCode.S)) {
			Vector3 Position = this.transform.position;
			Position.y -= 0.01f;
			this.transform.position = Position;
		}

		/*float MoveHorizontal = Input.GetAxis ("Horizontal");
		float MoveVertical = Input.GetAxis ("Vertical");

		Vector2 Movement = new Vector2 (MoveHorizontal, MoveVertical);

		RB2D.AddForce (Movement * Speed);*/
	}
}
