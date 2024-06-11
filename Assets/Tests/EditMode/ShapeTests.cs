using NUnit.Framework;

namespace Gameforge {
	public class ShapeTests {
		// A Test behaves as an ordinary method
		[Test]
		public void Shape() {
			Assert.AreEqual(1, (int)SpriteSetter.SpriteSelector.TRIANGLE);
			// Use the Assert class to test conditions
		}
	}
}
