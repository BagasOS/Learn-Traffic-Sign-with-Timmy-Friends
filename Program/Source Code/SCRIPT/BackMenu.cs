using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour {

	public string scenename;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {
			OpenScene();
		}


	}

	public void OpenScene(){

		SceneManager.LoadScene (scenename);


	}

}
