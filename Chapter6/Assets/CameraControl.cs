using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	private GameObject player = null;
	private Vector3 position_offset = Vector3.zero;

	// Use this for initialization
	void Start () {
	
		// メンバ変数playerにPlayerオブジェクトを取得
		this.player = GameObject.FindGameObjectWithTag ("Player");
		// カメラの位置(this.transform.position)とプレイヤの位置(this.player.transform.position)との差分を保管
		this.position_offset = this.transform.position - this.player.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate(){
	
		// カメラの現在位置をnew_positionに取得
		Vector3 new_position = this.transform.position;
		// プレイヤーのX座標に差分を足して、変数new_positionのXに代入する
		new_position.x = this.player.transform.position.x + this.position_offset.x;
		// カメラの位置を新しい位置に更新
		this.transform.position = new_position;
	
	
	}
}
