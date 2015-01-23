using UnityEngine;
using System.Collections;

public struct CollectibleItem {
	public string Type;
}

public class Collectible : MonoBehaviour {

	public string Type;

	 CollectibleItem item;

	// Use this for initialization
	void Start () {
		item.Type = Type;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		Collector collector = other.GetComponent<Collector>();

		if(collector != null) {
			collector.AddToCollection(item);
		}

		Destroy(gameObject);
	}
}
