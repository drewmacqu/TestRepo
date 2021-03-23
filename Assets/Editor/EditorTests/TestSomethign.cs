using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSomethign
    {
        [Test]
        public void InventorySystemCanAcceptItem()
        {
            var inventory = new Inventory();
            inventory.AddItem(new Item());
        }

        [Test]
        public void InventorySystemStoresItem()
        {
            var inventory = new Inventory();
            inventory.AddItem(new Item());
            Assert.AreEqual(inventory.NumberOfItems(), 1);
        }

        [Test]
        public void InventorySystemStoresItemsWhenAdded()
        {
            var inventory = new Inventory();
            inventory.AddItem(new Item());
            inventory.AddItem(new Item());
            Assert.AreEqual(inventory.NumberOfItems(), 2);
        }
    }
}
