﻿/**
 * Universidad de La Laguna
 * Escuela Superior de Ingeniería y Tecnología
 * Grado en Ingeniería Informática
 * Diseño y Análisis de Algoritmos
 * @author Daniel Hernandez de Leon
 * @date 08/05/2022
 * Main program
 */

using MaximumDiversityProblem;
using MaximumDiversityProblem.DataStructure;
using MaximumDiversityProblem.Algorithms.Approximated.LocalSearch;

MaximumDiversity maximumDiversity = new MaximumDiversity(
    "data/max_div_20_3.txt",
    "Greedy"
);

VectorsDistance solution = maximumDiversity.Run(5);

Console.WriteLine(solution);

VectorsDistance swapped = Swap.Search(solution);

Console.WriteLine(swapped);
