using UnityEngine;
using System.Collections;


namespace MLPlayer {		
	public class MoveTrigger : MonoBehaviour {

		public float speed;
		[SerializeField] GameObject Mob;
		bool is_moving = false;



		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
			if (is_moving) {
				Mob.transform.Translate (new Vector3 (speed, 0, 0));
				//Mob.transform.position += Mob.transform.Translate(new Vector3(1,0,0) ) * speed;	
			}
		}

		void OnEvent(GameObject other) {
			if (other.tag == Defs.PLAYER_TAG) {
				//gameObject.SetActive (false);
				is_moving = true;
				Debug.Log ("Mob Starts");

			}
		}

		void OnTriggerEnter(Collider other) {
			OnEvent (other.gameObject);
		}

		void OnCollisionEnter(Collision collision) {
			OnEvent (collision.gameObject);
		}

	}
}