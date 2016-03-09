using System;
	
	interface iSimpleCalc { 
    float add (float f1, float f2); 
	float subtract (float f1, float f2); 
	float multiply (float f1, float f2); 
	float divide (float f1, float f2); 
    }
  
	public class SimpleMath {

		public virtual int add(int f1, int f2){
			return f1+f2;
		}

		public virtual int subtract(int f1, int f2){
			return f1-f2;
		}

		public virtual int multiply(int f1, int f2){
			return f1*f2;
		}

		public virtual int divide(int f1, int f2){
			return (f1/f2);
		}
	}


