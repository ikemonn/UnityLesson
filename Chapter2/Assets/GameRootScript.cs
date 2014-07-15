using UnityEngine;
using System.Collections;

public class GameRootScript : MonoBehaviour {
	// Prefab
	public GameObject prefab = null;
	// sound
	private AudioSource audio;
	public AudioClip jumpSound;
	// 生成数
	private int objCnt = 0;
	// アイコン
	public Texture2D icon = null;
	// フォント
	private GUIStyle style;



	// 位置座標
	private Vector3 position;
	// スクリーン座標をワールド座標に変換した位置座標
	private Vector3 screenToWorldPointPosition;

	// Use this for initialization
	void Start () {
		// GameObjectに<AudioSource>コンポーネントを追加
		// これで音を扱えるようになる
		this.audio = this.gameObject.AddComponent<AudioSource> ();
		Debug.Log (this.audio);

		// jumpSoundに格納した音を鳴らすように準備
		this.audio.clip = this.jumpSound;

		//ループ再生を無効にする
		this.audio.loop = false;

		// フォント
		style = new GUIStyle ();
		style.fontSize = 30;

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			// Vector3でマウス位置を取得する
			position = Input.mousePosition; 
			// Z軸
			position.z = Random.Range (-3.0f, 10.0f);
			// マウス位置座標をスクリーン座標からワールド座標に変換する
			screenToWorldPointPosition = Camera.main.ScreenToWorldPoint (position);

			// prefab変数から作られたGameObjectを取得
			GameObject go =
				GameObject.Instantiate (this.prefab) as GameObject;

			go.transform.position = 
				new Vector3(screenToWorldPointPosition.x, screenToWorldPointPosition.y, screenToWorldPointPosition.z);
			// audioに入っている音を鳴らす
			this.audio.Play ();
			objCnt++;
		}

	}

	void OnGUI() {
		GUI.DrawTexture (new Rect(Screen.width / 2, 64, 64, 64), icon);
		GUI.Label (new Rect(Screen.width / 2, 128, 128, 32), "生成数" + objCnt.ToString(), style);

	}
}
