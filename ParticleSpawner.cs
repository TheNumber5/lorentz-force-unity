using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour {
	public GameObject proton, electron;
	public bool spawnParticles;
	public float waitTime, xM, yM, zM, xE, yE, zE;
	public bool spawnElectrons = false, randomColorOn = false, trailVisible = true; 
	void Start() {
		StartCoroutine(SpawnParticle());
	}
	IEnumerator SpawnParticle() {
		yield return new WaitForSeconds(waitTime);
		if(spawnParticles==true&&spawnElectrons==false) {
		GameObject instance = Instantiate(proton, this.transform.position, Quaternion.identity);
		LorentzForceParticle lfp = instance.GetComponent<LorentzForceParticle>();
		lfp.xM = xM;
		lfp.yM = yM;
		lfp.zM = zM;
		lfp.xE = xE;
		lfp.yE = yE;
		lfp.zE = zE;
			TrailRenderer renderer = instance.GetComponent<TrailRenderer>();
		if(randomColorOn) {
			renderer.startColor = new Color(Random.value, Random.value, Random.value, 1.0f);
			renderer.endColor = new Color(Random.value, Random.value, Random.value, 1.0f);
		}
		if(!trailVisible) {
			renderer.enabled = false;
		}
		}
		else if(spawnParticles==true&&spawnElectrons==true) {
		Instantiate(electron, this.transform.position, Quaternion.identity);
		}
		StartCoroutine(SpawnParticle());
	}
}