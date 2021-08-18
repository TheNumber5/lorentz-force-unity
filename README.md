# Description
A method for simulating the Lorentz Force on charged particles in Unity.

The Lorentz Force is a well-known force in physics, it shows that if a charged particle is in a electric field it will move, and if the particle is in a magnetic field its trajectory will be changed.

![Eqn](https://user-images.githubusercontent.com/30901594/129890404-b572adde-6dbe-45d4-9454-9b57653fb8f0.png)

This project simulates a simple case of the Lorentz Force in Unity, where the electric field is always in the Vector3.forward direction and the magnetic field is always in the y direction, or up.

The Sample Scene.unitypackage file, when imported to any Unity version after and including 2020.1.9f1, will show an example as viewed in the videos category.
Each particle must have the LorentzForceParticle.cs script attached to it. A game object that will be the simulation manager in this case needs to be created, where the ParticleManager.cs and the LorentzParticleOscillator.cs scripts need to be attached.

# Videos 

https://user-images.githubusercontent.com/30901594/129895315-ea1883c9-f365-4f31-bb0d-addba6e54d49.mp4

https://user-images.githubusercontent.com/30901594/129895683-248ed76d-a866-4cb8-bb5a-ac0d70a28826.mp4

https://user-images.githubusercontent.com/30901594/129896080-388a53c5-530b-476f-9401-7e84ef27f3a2.mp4
