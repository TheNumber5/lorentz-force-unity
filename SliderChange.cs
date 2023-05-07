using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderChange : MonoBehaviour {
	public Slider sliderMaxElectric, sliderMagnetic, sliderFrequency, timeScaleSlider, spawnFreqSlider;
	public LorentzParticleOscillator lpo;
	public Text maxElectricText, magneticText, frequencyText, timeScaleText, spawnFreqText;
	public TMP_InputField xM, yM, zM, xE, yE, zE, maxParticles;
	public Toggle randomColor, trailVisible;
	public GameObject controls;
	public ParticleSpawner spawner;
	private bool controlsVisible = false;
	void Update() {
		lpo.maxElectricField = sliderMaxElectric.value;
		lpo.magneticField = sliderMagnetic.value;
		lpo.frequency = sliderFrequency.value;
		lpo.maxParticles = int.Parse(maxParticles.text);
		spawner.waitTime = spawnFreqSlider.value;
		spawner.xM = float.Parse(xM.text);
		spawner.yM = float.Parse(yM.text);
		spawner.zM = float.Parse(zM.text);
		spawner.xE = float.Parse(xE.text);
		spawner.yE = float.Parse(yE.text);
		spawner.zE = float.Parse(zE.text);
		maxElectricText.text = sliderMaxElectric.value.ToString("0.0");
		magneticText.text = sliderMagnetic.value.ToString("0.0");
		frequencyText.text = sliderFrequency.value.ToString("0.0");
		spawnFreqText.text = spawnFreqSlider.value.ToString("0.00");
		Time.timeScale = timeScaleSlider.value;
		timeScaleText.text = Time.timeScale.ToString("0.0");
		if(randomColor.isOn)
			spawner.randomColorOn = true;
		else
			spawner.randomColorOn = false;
		if(trailVisible.isOn)
			spawner.trailVisible = true;
		else
			spawner.trailVisible = false;
	}
	public void ShowHideControls() {
		if(controlsVisible == true) {
		controls.SetActive(false);
		controlsVisible = false;
		}
		else {
		controls.SetActive(true);
		controlsVisible = true;
		}
	}
}