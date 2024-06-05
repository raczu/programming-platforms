package com.raczu.knapsack;

import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

class ProblemTest {

    @Test
    void Problem_whenNumberOfItemsIsNegative_ThrowIllegalArgumentException() {
        assertThrows(IllegalArgumentException.class, () -> new Problem(-1, 10));
    }

    @Test
    void Problem_whenNumberOfItemsIsCorrect_GenerateWantedNumberOfItems() {
        List<Integer> sizes = Arrays.asList(1, 10, 100, 1000);
        for (int size : sizes) {
            Problem problem = new Problem(size, 10);
            assertEquals(size, problem.items.size());
        }
    }

    @Test
    void solve_whenCapacityIsNegative_ThrowIllegalArgumentException() {
        Problem problem = new Problem(10, 10);
        assertThrows(IllegalArgumentException.class, () -> problem.solve(-1));
    }

    @Test
    void solve_whenNoItems_ReturnEmptyResult() {
        Problem problem = new Problem(0, 10);
        Result result = problem.solve(10);
        assertEquals(0, result.totalValue);
        assertEquals(0, result.totalWeight);
        assertEquals(0, result.items.size());
    }

    @Test
    void solve_whenCapacityIsZero_ReturnEmptyResult() {
        Problem problem = new Problem(10, 10);
        Result result = problem.solve(0);
        assertEquals(0, result.totalValue);
        assertEquals(0, result.totalWeight);
        assertEquals(0, result.items.size());
    }

    @Test
    void solve_whenItemsAndCapacity_ReturnResult() {
        Problem problem = new Problem(10, 10);
        Result result = problem.solve(100);
        assertFalse(result.items.isEmpty());
    }

    @Test
    void solve_whenItemsAndCapacity_ReturnCorrectResult() {
        List<Item> items = Arrays.asList(
                new Item(0, 4, 12),
                new Item(1, 2, 1),
                new Item(2, 1, 1),
                new Item(3, 2, 2),
                new Item(4, 10, 4)
        );

        Problem problem = new Problem(items);
        Result result = problem.solve(15);

        List<Item> expected = items.stream().filter(item -> item.number != 0).toList();
        assertTrue(expected.containsAll(result.items) && result.items.containsAll(expected));
        assertEquals(15, result.totalValue);
        assertEquals(8, result.totalWeight);
    }

    @Test
    void solve_WhenSameItemsOrderIsDifferent_ReturnsSameResult() {
        Problem problem01 = new Problem(10, 10);
        List<Item> items = new ArrayList<>(problem01.items);
        Collections.shuffle(items);
        Problem problem02 = new Problem(items);

        Result result01 = problem01.solve(15);
        Result result02 = problem02.solve(15);

        assertEquals(result01.totalValue, result02.totalValue);
        assertEquals(result01.totalWeight, result02.totalWeight);
        assertTrue(result01.items.containsAll(result02.items) && result02.items.containsAll(result01.items));
    }

    @Test
    void solve_whenCapacityIsExactlyWeightOfOneItem_ReturnThatItems() {
        List<Item> items = Arrays.asList(
                new Item(0, 10, 1),
                new Item(1, 5, 5),
                new Item(2, 1, 10)
        );

        Problem problem = new Problem(items);
        Result result = problem.solve(1);

        assertEquals(1, result.items.size());
        assertEquals(items.getFirst(), result.items.getFirst());
    }

    @Test
    void solve_whenCapacityIsMoreThanTotalWeight_ReturnAllItems() {
        List<Item> items = Arrays.asList(
                new Item(0, 10, 1),
                new Item(1, 5, 5),
                new Item(2, 1, 10)
        );

        Problem problem = new Problem(items);
        Result result = problem.solve(100);

        assertTrue(items.containsAll(result.items) && result.items.containsAll(items));
    }
}