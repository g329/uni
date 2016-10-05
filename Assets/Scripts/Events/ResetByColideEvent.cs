using UnityEngine;
using System.Collections;

namespace MLPlayer {
	public class ResetByColideEvent : MonoBehaviour {
		[SerializeField] float reward;

		void OnEvent(GameObject other) {
			Debug.Log ("On Event ======" );

			if (other.tag == Defs.PLAYER_TAG) {
				other.GetComponent<Agent> ().AddReward (reward);
				//gameObject.SetActive (false);
				Debug.Log ("ResetEvent reward:" + reward.ToString ());

				SceneController.Instance.TimeOver ();
			}
		}

		void OnTriggerEnter(Collider other) {
			Debug.Log ("On Trigger ======" );

			OnEvent (other.gameObject);
		}

		void OnCollisionEnter(Collision collision) {
			Debug.Log ("On Collision ======" );


			if (collision.gameObject.tag == Defs.PLAYER_TAG) {
				collision.gameObject.GetComponent<Agent> ().AddReward (reward);
				//gameObject.SetActive (false);
				Debug.Log ("ResetEvent reward:" + reward.ToString ());

				SceneController.Instance.TimeOver ();
			}
			OnEvent (collision.gameObject);
		}
	}
}
