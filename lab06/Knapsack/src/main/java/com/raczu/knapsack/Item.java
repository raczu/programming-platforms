package com.raczu.knapsack;

public class Item {
    public int number;
    public int value;
    public int weight;

    public Item(int number, int value, int weight) {
        this.number = number;
        this.value = value;
        this.weight = weight;
    }

    public float ratio() {
        return (float) this.value / this.weight;
    }

    @Override
    public String toString() {
        return String.format("Item(n=%d, value=%d, weight=%d)", this.number, this.value, this.weight);
    }
}
