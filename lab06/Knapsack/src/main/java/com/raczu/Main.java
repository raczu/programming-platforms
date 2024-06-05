package com.raczu;

import java.util.Scanner;
import com.raczu.knapsack.Problem;
import com.raczu.knapsack.Result;

public class Main {
    private static final String ERROR_MESSAGE = "Provided input is not a number";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter the number of items: ");
        if (!scanner.hasNextInt()) {
            System.out.println(ERROR_MESSAGE);
            return;
        }
        int n = scanner.nextInt();

        System.out.print("Enter the seed: ");
        if (!scanner.hasNextInt()) {
            System.out.println(ERROR_MESSAGE);
            return;
        }
        int seed = scanner.nextInt();

        System.out.print("Enter the capacity: ");
        if (!scanner.hasNextInt()) {
            System.out.println(ERROR_MESSAGE);
            return;
        }
        int capacity = scanner.nextInt();

        Problem problem = new Problem(n, seed);
        System.out.printf("%nProblem details: %s%n", problem);

        Result result = problem.solve(capacity);
        System.out.printf("%nResult:%nTotal weight: %d%nTotal value: %d%n", result.totalWeight, result.totalValue);
        System.out.println(result);
    }
}