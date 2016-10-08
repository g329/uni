using UnityEngine;
using System.Collections;


namespace MLPlayer {		
	public class Straight : MonoBehaviour {

		public float speed;
		[SerializeField] GameObject Mob;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {
				Mob.transform.Translate (new Vector3 (speed, 0, 0));
		}

		void OnEvent(GameObject other) {
			
		}

		void OnTriggerEnter(Collider other) {
		}

		void OnCollisionEnter(Collision collision) {

		}

	}
}