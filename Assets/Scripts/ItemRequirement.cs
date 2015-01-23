using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemRequirement : MonoBehaviour {

	public ParticleSystem ParticleSystem;
	public Collector Collector;
	public string ItemType = "Generic";
	public int RequiredQuantity = 1;

	void Start () {
		Component[] components = gameObject.GetComponents<Component>();

		foreach(Component component in components) {
			print (component.name);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Collector.ItemQuantity(ItemType) >= RequiredQuantity) {
			ParticleSystem.Emit (1);
		}
	}
}
