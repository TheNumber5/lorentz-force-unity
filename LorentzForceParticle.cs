using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LorentzForceParticle : MonoBehaviour {
	private Rigidbody particleRigidbody;
	public float charge, electricField, magneticField;
	public float xM, yM, zM;
	public float xE, yE, zE;
	void Awake() {
		particleRigidbody = this.gameObject.GetComponent<Rigidbody>();
		ParticleManager.instance.particleList.Add(this);
	}
	void FixedUpdate() {
		Vector3 magneticVector = new Vector3(xM*magneticField, yM*magneticField, zM*magneticField);
		Vector3 lorentzForce = new Vector3(xE, yE, zE)*charge*electricField+charge*Vector3.Cross(particleRigidbody.velocity, magneticVector);
		particleRigidbody.AddForce(lorentzForce*Time.deltaTime, ForceMode.Impulse);
	}
	public void Eliminate() {
		ParticleManager.instance.particleList.Remove(this);
		Destroy(this.gameObject, 0.01f);
	}
}