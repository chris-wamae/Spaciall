// Dictionary<(int, int), Action> choiceExplanation = new Dictionary<(int, int), Action>
// {
//     {(1, 1), () => Console.WriteLine("Hey")},
//     {(1, 2), () => Console.WriteLine("tyt")},
//     {(1, 3), () => Console.WriteLine("dade")},
//     {(1, 4), () => Console.WriteLine("dadeda")},
//     {(1, 5), () => Console.WriteLine("fvsvv")},
//     {(2, 1), () => Console.WriteLine("akja")},
//     {(2, 2), () => Console.WriteLine("oisrskj")},
//     {(2, 3), () => Console.WriteLine("opaiekjeakj")},
//     {(2, 4), () => Console.WriteLine("mccjccj")},
//     {(2, 5), () => Console.WriteLine("oeoepe")},
//     {(3, 1), () => Console.WriteLine("daEED")},
//     {(3, 2), () => Console.WriteLine("reueuru")},
//     {(3, 3), () => Console.WriteLine("Heydede")},
//     {(3, 4), () => Console.WriteLine("Heykfkfkfkfk")},
//     {(3, 5), () => Console.WriteLine("Heydeffe")}
// };

// Dictionary<(int, int), Action> choiceCalculation = new Dictionary<(int, int), Action>
// {
//     {(1, 1), () => Console.WriteLine("Hey")},
//     {(1, 2), () => Console.WriteLine("tyt")},
//     {(1, 3), () => Console.WriteLine("dade")},
//     {(1, 4), () => Console.WriteLine("dadeda")},
//     {(1, 5), () => Console.WriteLine("fvsvv")},
//     {(2, 1), () => Console.WriteLine("akja")},
//     {(2, 2), () => Console.WriteLine("oisrskj")},
//     {(2, 3), () => Console.WriteLine("opaiekjeakj")},
//     {(2, 4), () => Console.WriteLine("mccjccj")},
//     {(2, 5), () => Console.WriteLine("oeoepe")},
//     {(3, 1), () => Console.WriteLine("daEED")},
//     {(3, 2), () => Console.WriteLine("reueuru")},
//     {(3, 3), () => Console.WriteLine("Heydede")},
//     {(3, 4), () => Console.WriteLine("Heykfkfkfkfk")},
//     {(3, 5), () => Console.WriteLine("Heydeffe")}
// };



double calculationChoice = GetInput.Calculation_type();
double shapeChoice = GetInput.Shape_type(calculationChoice);
// if (choiceCalculations.TryGetValue((calculationChoice, shapeChoice), out Action action))
// {
//     action.Invoke();
// }
// else
// {
//     Console.WriteLine("Invalid choice");
// }
List<double> Measurements = GetInput.Figure_measurements();

// if (choiceCalculations.TryGetValue((calculationChoice, shapeChoice), out Action action))
// {
//     action.Invoke();
// }
// else
// {
//     Console.WriteLine("Invalid choice");
// }
