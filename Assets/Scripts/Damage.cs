using UnityEngine;

namespace Gameforge {
	public class Damage : MonoBehaviour {

		Player player;
		int totalDamage = 0;
		string noName = "NoNamePlayer";
		string moreExamples ="";

		private void Start() {
			player = FindObjectOfType<Player>();
		}

		public void TakeDamage(int damage) {
			player.Health -= damage;
			AddToTotalDamage(damage);
		}

		public void AddToTotalDamage(int damage) {
			totalDamage += damage;
		}

		public string GerNoName() => noName;

		public string GetMoreExamples() => moreExamples;
	}
}
