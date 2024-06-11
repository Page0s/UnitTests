using UnityEngine;

namespace Gameforge {
	public class GameManager : MonoBehaviour {

		[SerializeField] SpriteSetter spriteSetter;
		[SerializeField] Damage damage;

		Player player;

		private void Start() {
			player = FindObjectOfType<Player>();
		}

		private void Update() {
			if (Input.GetKeyDown(KeyCode.Mouse0)) {
				Debug.Log("CLICKED!");
				spriteSetter.SetSprite(SpriteSetter.SpriteSelector.TRIANGLE);
			}

			if (Input.GetKeyDown(KeyCode.Space)) {
				Debug.Log("TAKE DAMAGE!");
				damage.TakeDamage(10);
				Debug.Log($"Player new HP is {player.Health}");
			}
		}

		//private SpriteSetter.SpriteSelector GetRandomSpriteSelector() {
		//	SpriteSetter.SpriteSelector spriteSelector = new SpriteSetter.SpriteSelector();
		//	int randomIndex = Random.RandomRange(0, 2);
		//	switch (randomIndex) {
		//	case 0:
		//		spriteSelector
		//	}

		//	return spriteSelector;
		//}
	}
}
