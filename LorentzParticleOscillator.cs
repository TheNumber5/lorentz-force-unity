using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LorentzParticleOscillator : MonoBehaviour {
	public float charge, maxElectricField, magneticField;
	public float electricField, frequency;
	public int maxParticles;
	public bool changeAllParticles;
	void Start() {
		StartCoroutine(CheckIfTooManyParticles());
	}
	void FixedUpdate() {
		electricField = maxElectricField*Mathf.Sin(Time.time*frequency);
		if(changeAllParticles==true) {
		foreach(LorentzForceParticle particle in ParticleManager.instance.particleList) {
			particle.charge = charge;
			particle.electricField = electricField;
			particle.magneticField = magneticField;
		}
		}
	}
	IEnumerator CheckIfTooManyParticles() {
	yield return new WaitForSeconds(1f);
		if(ParticleManager.instance.particleList.Count>maxParticles) {
		for(int i=0; i<ParticleManager.instance.particleList.Count-maxParticles; i++) {
			ParticleManager.instance.particleList[i].Eliminate();
		}
	}
	StartCoroutine(CheckIfTooManyParticles());
	}
}