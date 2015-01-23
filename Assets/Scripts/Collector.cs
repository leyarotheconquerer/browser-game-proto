using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collector : MonoBehaviour {

	List<CollectibleItem> collection;

	// Use this for initialization
	void Start () {
		collection = new List<CollectibleItem>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddToCollection(CollectibleItem collectible) {
		this.collection.Add(collectible);
		print ("Collected Item (" + collectible.Type + ")");
	}

	public bool UseCollectibles(string type, int quantity) {
		if(ItemQuantity(type) >= quantity) {
			for(int i = 0; i < collection.Count; ++i) {
				if(collection[i].Type.Equals(type)) {
					collection.RemoveAt(i--);
					quantity--;
					if(quantity <= 0) {
						break;
					}
				}
			}
			return true;
		}
		else {
			return false;
		}
	}

	public int ItemQuantity(string type) {
		int quantity = 0;
		foreach(CollectibleItem item in collection) {
			if(item.Type.Equals(type)) {
				quantity++;
			}
		}
		return quantity;
	}
}
