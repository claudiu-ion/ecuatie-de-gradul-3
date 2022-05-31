using System;

namespace NumereComplexe
{

    public struct Complex
    {
        private double x, y;

        public Complex(double x, double y)
        {
            this.x = x;
            this.y = y;
        } 
        
        public override string ToString()
        {
            double eps = 1.0e-12;
            if (Math.Abs(y) < eps)             // z=real
                return string.Format("{0}", x);

            if (Math.Abs(x) < eps)             // z=imaginar
            {
                if (Math.Abs(y - 1) < eps)     //z=i
                    return "i";
                if (Math.Abs(y + 1) < eps)     //z=-i
                    return "-i";
                return string.Format("{0}i", y);
            }
            if (y > 0) 
                return string.Format("{0}+{1}i", x, y);
            return string.Format("{0}{1}i", x, y);
        }

        public void show()
        {
            Console.WriteLine(this);
        }
        public double Ro
        {
            get
            {
                return Math.Sqrt(x * x + y * y);
            }
            set
            {
                x = value * Math.Cos(Theta);
                y = value * Math.Sin(Theta);
            }
        }
        public double Ro2
        {
            get
            {
                return x * x + y * y;
            }
        }
        public double Theta
        {
            get
            {
                return Math.Atan2(y, x);
            }
            set
            {
                x = Ro * Math.Cos(value);
                y = Ro * Math.Sin(value);
            }
        }
        public double Re
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Im
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Complex Conj
        {
            get
            {
                return new Complex(x, -y);
            }
            set
            {
                x = value.x;
                y = -value.y;
            }
        }

        public static Complex setRoTheta(double Ro, double theta)
        {
            return new Complex(Ro * Math.Cos(theta), Ro * Math.Sin(theta));
        }
        public static Complex setReIm(double x, double y)
        {
            return new Complex(x, y);
        }

        public static Complex operator +(Complex zst, Complex zdr)
        {
            return new Complex(zst.x + zdr.x, zst.y + zdr.y);
        }

        public static Complex operator +(Complex zst)
        {
            return new Complex(zst.x, zst.y);
        }

        public static Complex operator -(Complex zst, Complex zdr)
        {
            return new Complex(zst.x - zdr.x, zst.y - zdr.y);
        }
        public static Complex operator -(Complex zst)
        {
            return new Complex(-zst.x, -zst.y);
        }
        public static Complex operator *(Complex zst, Complex zdr)
        {
            return new Complex(zst.x * zdr.x - zst.y * zdr.y, zst.y * zdr.x + zst.x * zdr.y);
        }
        public static Complex operator /(Complex zst, Complex zdr)
        {
            double r = zdr.Ro2;
            if (r < 1.0e-12) return Complex.setRoTheta(Double.MaxValue, zst.Theta - zdr.Theta);
            return new Complex((zst.x * zdr.x + zst.y * zdr.y) / r, (zst.y * zdr.x - zst.x * zdr.y) / r);
        }

        public static implicit operator Complex(double x)
        {
            return new Complex(x, 0);
        }

        public static bool operator ==(Complex zst, Complex zdr)
        {
            return (zst - zdr).Ro2 < 1.0e-16;
        }
        public static bool operator !=(Complex zst, Complex zdr)
        {
            return (zst - zdr).Ro2 >= 1.0e-16;
        }

        public override bool Equals(object o)
        {
            if (o.GetType() != this.GetType()) return false;
            else return this == (Complex)o;
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() + y.GetHashCode();
        }
        public Complex rlp(double k)
        {
            return Complex.setRoTheta(Math.Pow(this.Ro, k), this.Theta * k);
        }
        public Complex citire(string h)
        {
            int i = 0;
            Complex l = 0;
            bool ok=false,ok1 = false;
            if (h.Contains("+") == false && h.Contains("-") == false && h.Contains("i") == false) ok = true;
            else if(h.Contains("+") == false && h.Contains("-") == false && h.Contains("i") == true) ok = true;
            while (i < h.Length)
            {

                if (ok == false && ok1 == false )
                {
                    if (h[i] >= '0' && h[i] <= '9')
                    {

                        this = this * 10.0 + (h[i] - 48);
                        i++;
                    }
                    else if (h[i] == '+')
                    {
                        i++;
                        ok = true;

                    }
                    else if (i == 0 && h[0] == '-') { i++; }
                    else if (h[i] == '-')
                    {
                        i++;
                        ok1 = true;
                    }
                    else i++;
                }
                else if (h[i] >= '0' && h[i] <= '9')
                {
                    l = l * 10.0 + (h[i] - 48);
                    i++;
                }
                else i++;
            }
            if (h.Contains("i"))
            {
                if (l == 0 && h.Contains("0i") == false && h.Contains("0*i") == false) l = l + 1;
                if (h[0] == '-') this = -this;
                if (ok == true)
                    this = this + l * Complex.setReIm(0, 1);
                else if (ok1 == true)
                    this = this - l * Complex.setReIm(0, 1);
                else if (ok == false ) this = this * Complex.setReIm(0, 1);

            }
            else if (ok == true) { this = l; }
            else if (h[0] == '-') this = -this;
            else this = -l;
            if(h.Equals("-i")) this= -Complex.setReIm(0,1);
                    
            return this;

        }

    }
}
