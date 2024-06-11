using UnityEngine;

namespace Gameforge {
	public class Player : MonoBehaviour {

		public static Player Instance;

		public int Health { get => helth; set { helth = value; } }
		public float Damage { get => damage; set { damage = value; } }
		public string PlayerName { get => playerName; set { playerName = value; } }

		int helth;
		float damage;
		string playerName;

		private void Awake() {
			if (Instance != null){
				Destroy(Instance);
			}
			else {
				Instance = this;

				helth = 100;
				damage = 1;
				playerName = $"Page0";

				DontDestroyOnLoad(gameObject);
			}
		}
	}
}
