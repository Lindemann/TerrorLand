using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

	int counter;
	public Text textLeft;
	public Text textRight;

	void Start () {
		counter = 0;
		SetText (counter);
	}

	public void IncreaseCounter () {
		counter++;
		SetText (counter);
	}

	void SetText (int counter) {
		textLeft.text = "Score: " + counter.ToString ();
		textRight.text = "Score: " + counter.ToString ();
	}
}
