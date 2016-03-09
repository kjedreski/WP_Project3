using System;
using System.Numerics;

	interface iComplexCalc { 
        cFloat add (cFloat c1, cFloat c2); 
	    cFloat subtract (cFloat c1, cFloat c2); 
	    cFloat multiply (cFloat c1, cFloat c2); 
	    cFloat divide (cFloat c1, cFloat c2); 
    }

    public class cFloat{
      float real;
	  float img;
 
	  public cFloat(float r, float i)
	    {
        real = r; 
        img = i;
        }

	    public float getReal() { return real;}

	    public void setReal (float r) { real = r;}
 
	    public float getImg() { return img; }
 
	    public void setImg (float i) { img = i;} 
    }
	

	public class ComplexMath {

		public ComplexMath(){
		}

		public virtual Complex add(Complex c1,Complex c2){
			return c1+c2;
		}

		public virtual Complex subtract(Complex c1,Complex c2){
			return c1-c2;
		}

		public virtual Complex multiply(Complex c1,Complex c2){
			return c1*c2;
		}

		public virtual Complex divide(Complex c1,Complex c2){
			return c1/c2;
		}
	}
	
	
	
	


