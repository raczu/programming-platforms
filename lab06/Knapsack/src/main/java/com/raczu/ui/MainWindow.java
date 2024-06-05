package com.raczu.ui;

import javax.swing.*;
import javax.swing.event.CaretEvent;
import javax.swing.event.CaretListener;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import com.raczu.knapsack.Problem;
import com.raczu.knapsack.Result;

public class MainWindow {
    private JPanel mainPanel;
    private JTextField seedField;
    private JTextField capacityField;
    private JTextField itemsField;
    private JButton solveButton;
    private JLabel seedLabel;
    private JLabel capacityLabel;
    private JLabel itemsLabel;
    private JLabel problemDetailsLabel;
    private JLabel resultLabel;
    private JTextField totalValueField;
    private JTextField totalWeightField;
    private JLabel totalValueLabel;
    private JLabel totalWeightLabel;
    private JTextArea problemDetailsTextArea;
    private JTextArea resultTextArea;

    public MainWindow() {
        solveButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String seedInput = seedField.getText().trim();
                String capacityInput = capacityField.getText().trim();
                String numberOfItemsInput = itemsField.getText().trim();

                if (!isValidInput(seedInput) || !isValidInput(capacityInput) || !isValidInput(numberOfItemsInput)) {
                    JOptionPane.showMessageDialog(
                            mainPanel,
                            "Invalid input.",
                            "Error",
                            JOptionPane.ERROR_MESSAGE
                    );
                    return;
                }

                int seed = Integer.parseInt(seedInput);
                int capacity = Integer.parseInt(capacityInput);
                int numberOfItems = Integer.parseInt(numberOfItemsInput);

                Problem problem = new Problem(numberOfItems, seed);
                Result result = problem.solve(capacity);

                problemDetailsTextArea.setText(problem.toString());
                totalValueField.setText(Integer.toString(result.totalValue));
                totalWeightField.setText(Integer.toString(result.totalWeight));
                resultTextArea.setText(result.toString());
            }
        });
        seedField.addCaretListener(new CaretListener() {
            @Override
            public void caretUpdate(CaretEvent e) {
                setProperColor(seedField);
            }
        });
        capacityField.addCaretListener(new CaretListener() {
            @Override
            public void caretUpdate(CaretEvent e) {
                setProperColor(capacityField);
            }
        });
        itemsField.addCaretListener(new CaretListener() {
            @Override
            public void caretUpdate(CaretEvent e) {
                setProperColor(itemsField);
            }
        });
    }

    public boolean isValidInput(String input) {
        if (input == null || input.isEmpty()) {
            return false;
        }
        try {
            int number = Integer.parseInt(input);
            return number >= 0;
        } catch (NumberFormatException e) {
            return false;
        }
    }

    public void setProperColor(JTextField field) {
        String input = field.getText().trim();
        if (isValidInput(input)) {
            field.setForeground(null);
        } else {
            field.setForeground(java.awt.Color.RED);
        }
    }

    public static void main(String[] args) {
        JFrame frame = new JFrame("Knapsack solver");
        frame.setContentPane(new MainWindow().mainPanel);
        frame.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
        frame.pack();
        frame.setVisible(true);
    }
}
