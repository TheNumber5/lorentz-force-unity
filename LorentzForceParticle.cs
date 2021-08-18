using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LorentzForceParticle : MonoBehaviour {
	private Rigidbody particleRigidbody;
	public float charge, electricField, magneticField;
	void Awake() {
		particleRigidbody = this.gameObject.GetComponent<Rigidbody>();
		ParticleManager.instance.particleList.Add(this);
	}
	void FixedUpdate() {
		Vector3 magneticVector = new Vector3(0f, magneticField, 0f);
		Vector3 lorentzForce = Vector3.forward*charge*electricField+charge*Vector3.Cross(particleRigidbody.velocity, magneticVector);
		particleRigidbody.AddForce(lorentzForce*Time.deltaTime, ForceMode.Impulse);
	}
	public void Eliminate() {
		ParticleManager.instance.particleList.Remove(this);
		Destroy(this.gameObject, 0.01f);
	}
}