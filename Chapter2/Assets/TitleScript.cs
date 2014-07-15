using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// 左クリックすると
		if(Input.GetMouseButtonDown(0)){
			// studySceneに移行する
			Application.LoadLevel ("studyScene");
		}
	}

	void OnGUI(){
		// 画面にTitleと表示させる
		GUI.Label (new Rect(Screen.width/2, Screen.height/2, 128 , 32 ), "title画面だよ");
	}
}
