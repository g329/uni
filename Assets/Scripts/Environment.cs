using UnityEngine;
using System.Collections.Generic;

namespace MLPlayer {
	public class Environment : MonoBehaviour {

		int itemCount = 10;
		float areaSize = 10;
		[SerializeField] public GameObject goal;

		// events ( 0 is nothing )
		// -3.7 0.3 3.4


		// Use this for initialization
		void Start () {
			// x <= event < y
			int rand = Random.Range(0 , 2 + 1);

			if (rand == 1) {
				GameObject obj = (GameObject)Resources.Load ("MobCar");
				Instantiate (obj, new Vector3 (-3.7f, 0.3f, 3.4f), Quaternion.identity);
			} else if (rand == 2) {
				GameObject obj = (GameObject)Resources.Load ("MobHorse");
				Instantiate (obj, new Vector3 (-3.7f, 0.3f, 3.4f), Quaternion.identity);
			}
				
			
		}
		
		// Update is called once per frame
		void Update () {
		
		}

		public void OnReset() {
			GameObject[] mobs = GameObject.FindGameObjectsWithTag("Respawn");
			foreach(GameObject mob in mobs) {
				Destroy (mob);
			}

			int rand = Random.Range(0 , 2 + 1);

			if (rand == 1) {
				GameObject obj = (GameObject)Resources.Load ("MobCar");
				Instantiate (obj, new Vector3 (-3.7f, 0.3f, 3.4f), Quaternion.identity);
			} else if (rand == 2) {
				GameObject obj = (GameObject)Resources.Load ("MobHorse");
				Instantiate (obj, new Vector3 (-3.7f, 0.3f, 3.4f), Quaternion.identity);
			}

		}
	}
}
