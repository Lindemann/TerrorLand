using UnityEngine;
using System.Collections;

public class StartNewLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(Example());
	}

	IEnumerator Example() {
		yield return new WaitForSeconds(1);
		Application.LoadLevel("Game");
	}

}
