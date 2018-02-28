using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	AudioSource audio;

	public void SoundClick(AudioClip sound){
		
		audio = gameObject.GetComponent<AudioSource> ();
		this.audio.clip = sound;
		this.audio.PlayOneShot (sound);
	}


	public void GoToScene(string namascene){
		StartCoroutine (Delay());
		SceneManager.LoadScene (namascene);

	}
	IEnumerator Delay(){
		yield return new WaitForSeconds (10000f);
	}
}