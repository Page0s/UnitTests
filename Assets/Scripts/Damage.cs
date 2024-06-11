using UnityEngine;

namespace Gameforge {
	public class Damage : MonoBehaviour {

		Player player;
		int totalDamage = 0;

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
	}
}
