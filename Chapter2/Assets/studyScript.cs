using UnityEngine;
using System.Collections;

public class studyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.K)){
			this.transform.Translate(Vector3.forward * 3.0f * Time.deltaTime);
		}
	    if(Input.GetKey(KeyCode.J)){
			this.transform.Translate(Vector3.back * 3.0f * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.L)){
			this.transform.Translate(Vector3.right * 3.0f * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.H)){
			this.transform.Translate(Vector3.left * 3.0f * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.U)){
			this.transform.Translate(Vector3.up * 3.0f * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.D)){
			this.transform.Translate(Vector3.down * 3.0f * Time.deltaTime);
		}

		// Cubeを子にする
		if(Input.GetKey(KeyCode.P)){
			GameObject go = GameObject.Find ("Cube") as GameObject;
			go.transform.parent = this.transform;
		}

		// 親子関係を解除
		if(Input.GetKey(KeyCode.N)){
			GameObject go = GameObject.Find ("Cube") as GameObject;
			go.transform.parent = null;
		}

		if(Input.GetKey(KeyCode.G)){
			GameObject go = GameObject.Find ("Cube") as GameObject;
			go.GetComponent<cubeScript>().bigsize();
		}
	}
}
