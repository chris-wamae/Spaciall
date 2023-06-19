Dictionary<(double, double), Action> choiceExplanation = new Dictionary<(double, double), Action>
{
    {(1, 1), () => Console.WriteLine("Hey")},
    {(1, 2), () => Console.WriteLine("tyt")},
    {(1, 3), () => Console.WriteLine("dade")},
    {(1, 4), () => Console.WriteLine("dadeda")},
    {(1, 5), () => Console.WriteLine("fvsvv")},
    {(2, 1), () => Console.WriteLine("akja")},
    {(2, 2), () => Console.WriteLine("oisrskj")},
    {(2, 3), () => Console.WriteLine("opaiekjeakj")},
    {(2, 4), () => Console.WriteLine("mccjccj")},
    {(2, 5), () => Console.WriteLine("oeoepe")},
    {(2, 6), () => Console.WriteLine("oeoepe")},
    {(2, 7), () => Console.WriteLine("oeoepe")},
    {(3, 1), () => Console.WriteLine("daEED")},
    {(3, 2), () => Console.WriteLine("reueuru")},
    {(3, 3), () => Console.WriteLine("Heydede")},
    {(3, 4), () => Console.WriteLine("Heykfkfkfkfk")},
    {(3, 5), () => Console.WriteLine("Heydeffe")},
    {(3, 6), () => Console.WriteLine("Heydeffe")},
};

Dictionary<(double, double), Action> choiceCalculation = new Dictionary<(double, double), Action>
{
    {(1, 1), () => Console.WriteLine("Hey" + hey)},
    {(1, 2), () => Console.WriteLine("tyt")},
    {(1, 3), () => Console.WriteLine("dade")},
    {(1, 4), () => Console.WriteLine("dadeda")},
    {(1, 5), () => Console.WriteLine("fvsvv")},
    {(2, 1), () => Console.WriteLine("akja")},
    {(2, 2), () => Console.WriteLine("oisrskj")},
    {(2, 3), () => Console.WriteLine("opaiekjeakj")},
    {(2, 4), () => Console.WriteLine("mccjccj")},
    {(2, 5), () => Console.WriteLine("oeoepe")},
    {(2, 6), () => Console.WriteLine("oeoepe")},
    {(2, 7), () => Console.WriteLine("oeoepe")},
    {(3, 1), () => Console.WriteLine("daEED")},
    {(3, 2), () => Console.WriteLine("reueuru")},
    {(3, 3), () => Console.WriteLine("Heydede")},
    {(3, 4), () => Console.WriteLine("Heykfkfkfkfk")},
    {(3, 5), () => Console.WriteLine("Heydeffe")},
    {(3, 6), () => Console.WriteLine("Heydeffe")},
};



double calculationChoice = GetInput.Calculation_type();

double shapeChoice = GetInput.Shape_type(calculationChoice);

List<double> Measurements = GetInput.Figure_measurements();


if (choiceExplanation.TryGetValue((calculationChoice, shapeChoice), out Action action))
{
    action.Invoke();
}
else
{
    Console.WriteLine("Invalid choice");
}


if (choiceCalculation.TryGetValue((calculationChoice, shapeChoice), out Action calculation))
{
    calculation.Invoke();
}
else
{
    Console.WriteLine("Invalid choice");
}
