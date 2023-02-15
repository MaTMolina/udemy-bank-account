namespace FirstProject {
    public class Triangle {
        public double A;
        public double B;
        public double C;

        public double getArea() {
            double p = (A + B + C / 2.0);
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        }
    }
}

