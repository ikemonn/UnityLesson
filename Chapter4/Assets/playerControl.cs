using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {
	private float power;
	public float POWERPLUS = 250.0f;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		// 左ボタンが押されている間
		if(Input.GetMouseButton(0)){
			power += POWERPLUS * Time.deltaTime;
		}
		// 左ボタンが離されたら
		if(Input.GetMouseButtonUp(0)){
			// ためた力をx,yに反映させて右上にジャンプ
			this.rigidbody.AddForce (new Vector3(power, power, 0));
			power = 0.0f;
		}

		// 地面より下に落ちたらシーンをリロード
		if(this.transform.position.y < -5.0f){
			Application.LoadLevel ("gameScene");
		}
	}
}
