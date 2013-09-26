using UnityEngine;
using System.Collections;

public class Particles : MonoBehaviour {
	
	
	ParticleSystem.Particle[] particles_ = new ParticleSystem.Particle[10000];
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
		int count = gameObject.particleSystem.GetParticles(particles_);
		
		for (int i = 0 ; i< count; i++) {
		
			particles_[i].color = new Color (Random.value,Random.value,Random.value,1);
			
		}
		
		gameObject.particleSystem.SetParticles(particles_, count);
		
	}
}
