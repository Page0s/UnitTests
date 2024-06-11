using UnityEngine;

namespace Gameforge {
	public class SpriteSetter : MonoBehaviour {

		[SerializeField] Sprite sprite;
		[SerializeField] SpriteRenderer spriteRenderer;
		[SerializeField] Sprite sphere;
		[SerializeField] Sprite triangle;
		[SerializeField] Sprite capsule;

		public enum SpriteSelector {
			SPHERE = 0,
			TRIANGLE = 1,
			CAPSULE = 2
		}

		private void Awake() {
			spriteRenderer = GetComponent<SpriteRenderer>();
		}

		private void Start() {
			spriteRenderer.sprite = sprite;
		}

		public void SetSprite(Sprite sprite) {
			spriteRenderer.sprite = sprite;
		}

		public void SetSprite(SpriteSelector selector) {
			switch (selector) {
			case SpriteSelector.SPHERE:
				spriteRenderer.sprite = sphere;
				break;
			case SpriteSelector.TRIANGLE:
				spriteRenderer.sprite = triangle;
				break;
			case SpriteSelector.CAPSULE:
				spriteRenderer.sprite = capsule;
				break;
			}
		}
	}
}