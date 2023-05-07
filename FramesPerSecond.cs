using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FramesPerSecond : MonoBehaviour {
	public float framesPerSecond;
	public Text fpsText;
	void Update() {
		fpsText.text = "FPS: " + (1f/Time.unscaledDeltaTime).ToString("0");
	}
}