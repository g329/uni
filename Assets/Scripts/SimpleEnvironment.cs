using UnityEngine;
using System.Collections.Generic;

namespace MLPlayer {
	public class SimpleEnvironment : MonoBehaviour {

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}

		public void OnReset() {
			GameObject[] mobs = GameObject.FindGameObjectsWithTag("Respawn");
			foreach(GameObject mob in mobs) {
				Destroy (mob);
			}
		}
	}
}
