using UnityEngine;
using System.Collections;

public class RigidBodyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//↑キーで奥へ
		if(Input.GetKey(KeyCode.UpArrow)){
			this.transform.rigidbody.AddForce (
				Vector3.forward * 300 * Time.deltaTime);
		}
		//↓キーで手前へ
		if(Input.GetKey(KeyCode.DownArrow)){
			this.transform.rigidbody.AddForce (
				Vector3.back * 300 * Time.deltaTime);
		}
		// ←キーで左へ
		if(Input.GetKey(KeyCode.LeftArrow)){
			this.transform.rigidbody.AddForce (
				Vector3.left * 300 * Time.deltaTime);
		}
		// →キーで右へ
		if(Input.GetKey(KeyCode.RightArrow)){
			this.transform.rigidbody.AddForce (
				Vector3.right * 300 * Time.deltaTime);
		}

		// Uキーで上へ
		if(Input.GetKey(KeyCode.U)){
			this.transform.rigidbody.AddForce (
				Vector3.up * 300 * Time.deltaTime);
		}
		// Dキーで下へ
		if(Input.GetKey(KeyCode.D)){
			this.transform.rigidbody.AddForce (
				Vector3.down * 300 * Time.deltaTime);
		}
		// Aで無重力に
		if(Input.GetKeyDown(KeyCode.A)){
			Physics.gravity = Vector3.zero;
		}
		// Bで重力を左方向に
		if(Input.GetKeyDown(KeyCode.B)){
			Physics.gravity = Vector3.left;
		}

		// Cで重力を右方向に
		if(Input.GetKeyDown(KeyCode.C)){
			Physics.gravity = Vector3.right;
		}
	
	}
}
