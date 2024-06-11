using NUnit.Framework;
using System.Collections;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TestTools;

namespace Gameforge {
	public class SpriteTests {
		[UnityTest]
		public IEnumerator SetSprite() {
			// Create a GameObject and add the Player component to it
			GameObject gameObject = new GameObject();
			gameObject.AddComponent<SpriteRenderer>();
			SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
			SpriteSetter spriteSetter = gameObject.AddComponent<SpriteSetter>();

			// Load a sprite to test (ensure this sprite exists in your Assets folder)
			Sprite newSprite = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Sprites/TriangleY.png");

			Debug.Log(newSprite);

			// Act: Change the player's sprite
			spriteSetter.SetSprite(newSprite);

			// Assert: The sprite renderer's sprite is now the new sprite
			Assert.AreEqual(newSprite, spriteRenderer.sprite);

			// Cleanup
			Object.DestroyImmediate(gameObject);


			// Use yield to skip a frame.
			yield return null;
		}
	}
}
