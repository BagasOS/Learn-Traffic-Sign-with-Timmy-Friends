using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Tesquest : MonoBehaviour {

	public List<AudioClip> ListSound;
	public int index;

	AudioSource audio;

	public Image benar;
	public Image salah;



	private static Tesquest instance;

	public static Tesquest Instance {
		get{ 
		
			if (instance == null) {

				instance = GameObject.FindObjectOfType<Tesquest>();

			}
			return instance;

		}

	}

	public void RandomSoal(){
		audio = GetComponent<AudioSource> ();
		index = Random.Range (0, 13);
		audio.clip = ListSound [index];
		audio.Play();
	}


	public void stoprandom(){

		if (audio.isPlaying) {

			audio.Stop ();
		}

	}

	public void CekJawaban(int indexsoal){

		if (indexsoal == 1) {

			StartCoroutine (Tesquest.Instance.TampilHasil (true));
		} else {

			StartCoroutine (Tesquest.Instance.TampilHasil (false));
		}

	}

	public IEnumerator TampilHasil(bool hasil){

		if (hasil) {

			benar.enabled = true;
			yield return new WaitForSeconds (2f);
			benar.enabled = false;

		} else {

			salah.enabled = true;
			yield return new WaitForSeconds (2f);
			salah.enabled = false;


		}

	}
	// Use this for initialization
	void Start () {

		benar.enabled = false;
		salah.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
