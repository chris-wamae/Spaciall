public class Volume : Area {
    
    public static double Cube(params double[] sides){
        double square_side = sides[0];
       return Volume.Square(square_side) * square_side;

    }

    public static double Cuboid(params double[] sides){
        
        double length = sides[0];
        double width = sides[1];
        double height = sides[2];

        return Volume.Rectangle(length, width) *  height;

    }

    public static double Sphere(params double[] radius){

        return Volume.Circle(radius[0]) * 4/3 * radius[0];

    }

    public static double Cone(params double[] sides){
        
        double radius = sides[0];
        double height = sides[1];

        return Volume.Circle(radius) * 1/3 * height;

    }

    public static double Square_pyramid(params double[] sides){
        
        double square_sideside = sides[0];
        double vertical_height = sides[1];
    
        return Volume.Square(square_sideside) * 1/3 * vertical_height; 

    }
    
    public static double Triangular_pyramid(params double[] sides){

        double ca_base = sides[0];
        double ca_height = sides[1];
        double height = sides[2];

        return Volume.Triangle_right_angled(ca_base,ca_height) * 1/3 * height; 

    }
    


    public  static double Cone_slant(params double[] sides){

        double slant_height = sides[0];

        double radius = sides[1];
        
        double straight_height = Calculation_helper.Triangle_height(slant_height, radius);
        
        return Volume.Cone(radius, straight_height);

    } 

    public static double Square_pyramid_slant(params double[] sides){

        double slant_height = sides[0];

        double side = sides[1];

        double straight_height =  Calculation_helper.Triangle_height(slant_height, side);

        return Volume.Square_pyramid(side, straight_height);
        
    }



}