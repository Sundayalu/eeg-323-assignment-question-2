using System;

namespace Assignment_Program_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //alu sunday ayo
          // ees/19/20/0155
            //this is the answer to number 2

           int a, b, c, d, e, f, q1, q2, q3, x, y;
                 // first element of the matrix
                 Console.WriteLine("input first element of the matrix:_");
                 a  = Convert.ToInt32(Console.ReadLine()); 
                

                 // second element of the matrix
                 Console.WriteLine("input second element of the matrix:_"); 
                 b  = Convert.ToInt32(Console.ReadLine()); 

                   // third element of the matrix
                 Console.WriteLine("input third element of the matrix:_"); 
                 c  = Convert.ToInt32(Console.ReadLine()); 

                   // fourth element of the matrix
                 Console.WriteLine("input fourth element of the matrix:_"); 
                 d  = Convert.ToInt32(Console.ReadLine()); 


                   // fifth element of the matrix
                 Console.WriteLine("input fifth element of the matrix:_"); 
                 e  = Convert.ToInt32(Console.ReadLine()); 

                   // sixth element of the matrix
                 Console.WriteLine("input sixth element of the matrix:_"); 
                 f  = Convert.ToInt32(Console.ReadLine()); 

                 // now to find n1
                  q1 = Convert.ToInt32(a*d - b*c); 
                  Console.WriteLine(q1);
                   Console.WriteLine("our n1 is equals to" + q1);
                   if(q1 == 0){
                       Console.WriteLine("The Equation has no solution");   
                   }
                  

                   // now to find n2
                  q2 = Convert.ToInt32(e*d - f*c); 
                  Console.WriteLine(q2);
                   Console.WriteLine("our q3 is equals to " + q2);



                 // now to find n3
                  q3 = Convert.ToInt32(a*f - b*e); 
                  Console.WriteLine(q3);
                   Console.WriteLine("our q2 is equals to " + q3);

                   //now to find x 
                   x = Convert.ToInt32(q2 / q1); 
                  Console.WriteLine(x);
                   Console.WriteLine("our x is equals to " + x);

                   //now to find y 
                   y = Convert.ToInt32(q3 / q1); 
                  Console.WriteLine(y);
                   Console.WriteLine("our y is equals to " + y);


                   
                  


        }
    }
}
