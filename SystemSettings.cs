using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemSettings : MonoBehaviour {
	void Start() {
		Screen.SetResolution(1280, 720, false);
		Application.targetFrameRate = 60;
	}
}