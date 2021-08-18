using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour {
	public static ParticleManager instance;
	public List<LorentzForceParticle> particleList;
	void Start() {
		if(instance == null) {
			instance = this;
		}
	}
}