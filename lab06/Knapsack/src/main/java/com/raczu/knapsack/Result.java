package com.raczu.knapsack;

import java.util.List;

public class Result {
    public int totalValue;
    public int totalWeight;
    public final List<Item> items;

    public Result(List<Item> items) {
        this.totalValue = 0;
        this.totalWeight = 0;

        for (Item item : items) {
            this.totalValue += item.value;
            this.totalWeight += item.weight;
        }
        this.items = items;
    }

    @Override
    public String toString() {
        return String.join("\n", this.items.stream().map(Item::toString).toList());
    }
}
