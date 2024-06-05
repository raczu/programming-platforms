package com.raczu.knapsack;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class ItemTest {

    @Test
    void ratio_returnsCorrectValue() {
        Item item = new Item(1, 10, 5);
        assertEquals(2.0, item.ratio());
    }
}