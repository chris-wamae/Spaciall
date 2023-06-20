
double calculationChoice = GetInput.Calculation_type();

double shapeChoice = GetInput.Shape_type(calculationChoice);

Dictionary<(double, double), Action> choiceExplanation = new Dictionary<(double, double), Action>
{
    {(1, 1), () => InputExplanations.SquarePermieter()},
    {(1, 2), () => InputExplanations.RectanglePermieter()},
    {(1, 3), () => InputExplanations.TrianglePerimeter()},
    {(1, 4), () => InputExplanations.Circumfrence()},
    {(1, 5), () => InputExplanations.TrapeziumPerimeter()},
    {(1, 6), () => InputExplanations.TrapeziumPerimeterStraight()},
    {(2, 1), () => InputExplanations.SquareArea()},
    {(2, 2), () => InputExplanations.RecatangleArea()},
    {(2, 3), () => InputExplanations.CircleArea()},
    {(2, 4), () => InputExplanations.TriangleArea()},
    {(2, 5), () => InputExplanations.TriangleArea_slant()},
    {(2, 6), () => InputExplanations.TrapeziumArea()},
    {(2, 7), () => InputExplanations.TrapeziumArea_slant()},
    {(3, 1), () => InputExplanations.SquareVolume()},
    {(3, 2), () => InputExplanations.CuboidVolume()},
    {(3, 3), () => InputExplanations.SphereVolume()},
    {(3, 4), () => InputExplanations.ConicalVolume()},
    {(3, 5), () => InputExplanations.ConicalVolumeSlant()},
    {(3, 6), () => InputExplanations.Square_pyramid()},
    {(3, 7), () => InputExplanations.SquarePyramidSlant()},
    {(3, 8), () => InputExplanations.Triangular_pyramid()}
};

if (choiceExplanation.TryGetValue((calculationChoice, shapeChoice), out Action action))
{
    action.Invoke();
}
else
{
    Console.WriteLine("Invalid choice");
}



List<double> Measurements = GetInput.Figure_measurements();


Dictionary<(double, double), Action> choiceCalculation = new Dictionary<(double, double), Action>
{
    {(1, 1), () => Console.WriteLine(Perimeter.Square(Measurements.ToArray()))},
    {(1, 2), () => Console.WriteLine(Perimeter.Rectangle(Measurements.ToArray()))},
    {(1, 3), () => Console.WriteLine(Perimeter.Triangle(Measurements.ToArray()))},
    {(1, 4), () => Console.WriteLine(Perimeter.Circle(Measurements.ToArray()))},
    {(1, 5), () => Console.WriteLine(Perimeter.Trapezium(Measurements.ToArray()))},
    {(1, 6), () => Console.WriteLine(Perimeter.Trapezium_straight(Measurements.ToArray()))},
    {(2, 1), () => Console.WriteLine(Area.Square(Measurements.ToArray()))},
    {(2, 2), () => Console.WriteLine(Area.Rectangle(Measurements.ToArray()))},
    {(2, 3), () => Console.WriteLine(Area.Circle(Measurements.ToArray()))},
    {(2, 4), () => Console.WriteLine(Area.Triangle_right_angled(Measurements.ToArray()))},
    {(2, 5), () => Console.WriteLine(Area.Triangle_isosceles_slant(Measurements.ToArray()))},
    {(2, 6), () => Console.WriteLine(Area.Trapezium_straight(Measurements.ToArray()))},
    {(2, 7), () => Console.WriteLine(Area.Trapezium_slant(Measurements.ToArray()))},
    {(3, 1), () => Console.WriteLine(Volume.Cube(Measurements.ToArray()))},
    {(3, 2), () => Console.WriteLine(Volume.Cuboid(Measurements.ToArray()))},
    {(3, 3), () => Console.WriteLine(Volume.Sphere(Measurements.ToArray()))},
    {(3, 4), () => Console.WriteLine(Volume.Cone(Measurements.ToArray()))},
    {(3, 5), () => Console.WriteLine(Volume.Cone_slant(Measurements.ToArray()))},
    {(3, 6), () => Console.WriteLine(Volume.Square_pyramid(Measurements.ToArray()))},
    {(3, 7), () => Console.WriteLine(Volume.Square_pyramid_slant(Measurements.ToArray()))},
    {(3, 8), () => Console.WriteLine(Volume.Triangular_pyramid(Measurements.ToArray()))}
};








if (choiceCalculation.TryGetValue((calculationChoice, shapeChoice), out Action calculation))
{
    calculation.Invoke();
}
else
{
    Console.WriteLine("Invalid choice");
}
