public class Volume : Area {
    
    public static double Cube(double side){

       return Volume.Square(side) * side;

    }

    public static double Cuboid(double length, double width,double height){

        return Volume.Rectangle(length, width) *  height;

    }

    public static double Sphere(double radius){

        return Volume.Circle(radius) * 4/3 * radius;

    }

    public static double Cone(double radius, double height){

        return Volume.Circle(radius) * 1/3 * height;

    }

    public static double Square_pyramid(double side, double height){

        return Volume.Square(side) * 1/3 * height; 

    }
    
    public static double Triangular_pyramid(double ca_base, double ca_height,double height){

        return Volume.Triangle_isosceles(ca_base,ca_height) * 1/3 * height; 

    }
    


    public  static double Cone_slant(double slant_height, double radius){
        
        double straight_height = Calculation_helper.Triangle_height(slant_height, radius);
        
        return Volume.Cone(radius, straight_height);

    } 

    public static double Square_pyramid_slant(double slant_height, double side){

        double straight_height =  Calculation_helper.Triangle_height(slant_height, side);

        return Volume.Square_pyramid(side, straight_height);
        
    }



}