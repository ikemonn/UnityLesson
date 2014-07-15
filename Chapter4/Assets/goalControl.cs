using UnityEngine;
using System.Collections;

public class goalControl : MonoBehaviour {
	private bool is_collided = false;
	public float GOAL_MIN = 2.0f;
	public float GOAL_MAX = 3.0f;
	public float GOAL_MOVE = 0.5f;
	private Vector3 goal_pos;
	private Vector3 start_goal_pos;
	private bool is_move_right = true;
	private GUIStyle style;



	// Use this for initialization
	void Start () {
		// GOAL_MIN ~ GOAL_MAXの間のランダムな値を取得
		float rnd = Random.Range (GOAL_MIN, GOAL_MAX);
		// GoalのX位置をランダムな値に
		start_goal_pos = this.transform.position = new Vector3 (rnd, -1.0f, 0.0f);
		// 成功時のフォントサイズ
		style = new GUIStyle ();
		style.fontSize = 30;
	}
	
	// Update is called once per frame
	void Update () {
		// ゴールの位置
		goal_pos = this.transform.position;
		//左右どちらに進むかフラグ管理
		if(goal_pos.x >= start_goal_pos.x + GOAL_MOVE){
			is_move_right = false;                     // ゴールの可動領域の右端までいくと右へ進むフラグをfalseに
		} else if (goal_pos.x <= start_goal_pos.x - GOAL_MOVE){
			is_move_right = true;                     // ゴールの可動領域の左端までいくと右へ進むフラグをtrueに
		}

		// trueなら右に、falseなら左に進む
		if (is_move_right == true) {
			this.transform.Translate (Vector3.right * 1.0f * Time.deltaTime);
		} else {
			this.transform.Translate (Vector3.left * 1.0f * Time.deltaTime);
		}



	
	}

	// 他のGameObjectとぶつかっている間呼ばれ続ける
	void OnCollisionStay(Collision other){
		this.is_collided = true;
	}

	void OnGUI(){
		if(is_collided){
			Rect rect = new Rect (Screen.width / 2, 80, 100, 20);
			style.fontStyle = FontStyle.Bold;
			//画面に成功と表示
			GUI.Label (rect, "成功！！", style);
		}
	}
}
