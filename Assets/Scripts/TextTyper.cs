using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextTyper : MonoBehaviour {
	public float letterDelay = 0.2f;
	public AudioClip clickSound;
	string message;
	Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		message = text.text;
		text.text = "";
		StartCoroutine(TypeText ());
	}

	IEnumerator TypeText () {
		foreach (char letter in message.ToCharArray()) {
			text.text += letter;
			if (text.text.Length > 20) {
				text.text = text.text.Substring (1);
			}
			if (clickSound != null) {
				//SoundManager.playSound (clickSound);
			}
			yield return new WaitForSeconds (letterDelay);
		}
	}
}
