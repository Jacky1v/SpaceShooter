using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	private Button btn;
	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindWithTag ("Button");
		 btn = go.GetComponent<Button> ();
		btn.onClick.AddListener (OnClick);
	}

	// Update is called once per frame
	void Update () {

	}

	 void OnClick()
	{
		SceneManager.LoadScene(1);
	}
	       

}