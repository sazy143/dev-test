# Gilded Rose Requirements Specification

Hi and welcome to team Gilded Rose. As you know, we are a small shop with a prime location in a
prominent city ran by a friendly innkeeper named Allison. We also buy and sell only the finest foods.
Unfortunately, our foods are constantly degrading in quality as they approach their sell by date. We
have a system in place that updates our inventory for us. Your task is to add the new feature to our
system so that we can begin selling a new category of items.

First an introduction to our system:
  - All items have a SellIn value which denotes the number of days we have to sell the item
  - All items have a Quality value which denotes how valuable the item is
  - At the end of each day our system lowers both values for every item

These are the existing rules that are run against items, this does not include "Baked" items":
  - Once the sell by date has passed, Quality degrades twice as fast
  - The Quality of an item is never negative
  - "Aged Brie" actually increases in Quality the older it gets
  - The Quality of an item is never more than 50
  - "Canned Beans", being a non-perishable, never has to be sold or decreases in Quality

Feature Requirement:
  - We have recently signed a baker, who will provide freshly baked goods. This requires an update to our system.
  - We must support "Baked" items, which will degrade in Quality twice as fast as normal items

Feel free to make any changes to the UpdateQuality method and add any new code as long as everything
still works correctly. However, do not alter the Item class or Items property.

Just for clarification, an item can never have its Quality increase above 50, however "Canned Beans" is a
non-perishable item and as such its Quality is 80 and it never alters.
