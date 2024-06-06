package com.raczu.knapsack;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Random;

public class Problem {
    public List<Item> items;

    public Problem(List<Item> items) {
        this.items = items;
    }

    public Problem(int n, int seed, int lowerBound, int upperBound) throws IllegalArgumentException {
        if (n < 0) {
            throw new IllegalArgumentException("Number of items cannot be negative");
        }

        this.items = new ArrayList<>();
        Random random = new Random(seed);

        for (int i = 0; i < n; i++) {
            int value = random.nextInt(lowerBound, upperBound) + 1;
            int weight = random.nextInt(lowerBound, upperBound) + 1;
            this.items.add(new Item(i, value, weight));
        }
    }

    public Result solve(int capacity) throws IllegalArgumentException {
        if (capacity < 0) {
            throw new IllegalArgumentException("Capacity cannot be negative");
        }

        if (this.items.isEmpty()) {
            return new Result(List.of());
        }

        List<Item> sorted = new ArrayList<>(this.items);
        sorted.sort(Comparator.comparing(Item::ratio).reversed());
        List<Item> packed = new ArrayList<>();

        for (Item item : sorted) {
            while (item.weight <= capacity) {
                packed.add(item);
                capacity -= item.weight;
            }
        }

        return new Result(packed);
    }

    @Override
    public String toString() {
        return String.join("\n", this.items.stream().map(Item::toString).toList());
    }
}
