using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		StartGameOverScene();
    }

	void StartGameOverScene () {
		Application.LoadLevel("GameOver");
	}
}
