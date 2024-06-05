package com.raczu.knapsack;

import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

class ResultTest {

    @Test
    void Result_whenEmptyItems_SetTotalValueAndTotalWeightToZero() {
        Result result = new Result(List.of());
        assertEquals(0, result.totalValue);
        assertEquals(0, result.totalWeight);
    }

    @Test
    void Result_whenItemsAreGiven_CalculateTotalValueAndTotalWeight() {
        Item item1 = new Item(1, 10, 5);
        Item item2 = new Item(2, 20, 10);
        Result result = new Result(List.of(item1, item2));
        assertEquals(30, result.totalValue);
        assertEquals(15, result.totalWeight);
    }
}