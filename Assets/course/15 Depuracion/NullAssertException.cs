using System;
using UnityEngine;
using UnityEngine.Assertions;

namespace Course.Depuracion
{
    public class NullAssertException : MonoBehaviour
    {
        public Item currentItem;
        public Item equippedItem;

        public bool isDead;

        public float currentHealth;
        public float maxHealth;

        private void Start()
        {
            // Null (Code Smell)
            if (currentItem == null)
            {
                currentItem = GetComponent<Item>();
            }

            // Not Null (Code Smell)
            if (currentItem != null)
            {
                currentItem.Consume();
            }

            currentItem?.Consume();

            // Exception
            if (currentItem == null)
            {
                throw new Exception("Item can't be null!");
            }

            // Assert - Null
            Assert.IsNotNull(currentItem, "Item can't be null!");
            Assert.IsNull(currentItem, "Item should be null!");

            // Assert - Bool
            Assert.IsTrue(isDead, "Player should be dead!");
            Assert.IsFalse(isDead, "Player can't be dead!");

            // Assert - Equal
            Assert.AreEqual(currentItem, equippedItem, "Items should be the same!");
            Assert.AreNotEqual(currentItem, equippedItem, "Items can't be the same!");

            // Assert - Approximately Equal
            Assert.AreApproximatelyEqual(currentHealth, maxHealth, 1f, "Health should be almost the same that max!"); 
            Assert.AreNotApproximatelyEqual(currentHealth, maxHealth, 1f, "Health can't be be almost the same that max!"); 
        }

    }
}
