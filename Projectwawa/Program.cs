/*
opg 1

 Console.WriteLine("Hello");

 Console.WriteLine("Ebbe!");
    
opg 2

Console.WriteLine("2 + 2 = {0}", 2+2);

opg 3

int num;
Console.WriteLine("\n\n");
Console.Write("input an integer : ");
num=Convert.ToInt32(Console.ReadLine());

if (num >= 0)
Console.WriteLine("{0} is positive",num);

    else
{
    Console.WriteLine("{0} is negative",num);
}

opg 4

int year;

Console.WriteLine("\n\n");
    Console.Write("input an year : ");
        year=Convert.ToInt32(Console.ReadLine());

if ((year % 400) == 0)
Console.WriteLine("{0} is a leap year",year);
    else if ((year % 100) == 0)
    Console.WriteLine("{0} is not a leap year",year);
    else if((year % 4) == 0)
    Console.WriteLine("{0} is a leap year",year);
    else
    Console.WriteLine("{0} is not a leap year",year);
    
opg 5

int age;

Console.Write("\n\n");
    Console.Write("input an age : ");
        age=Convert.ToInt32(Console.ReadLine());

if (age >= 18)
Console.WriteLine("Congrats you can vote");
    else
    Console.WriteLine("wah wah you cant vote");

    opg 6

int m,n;
Console.Write("\n\n");
    Console.Write("input a number : ");
        m=Convert.ToInt32(Console.ReadLine());

if (m >= 0)
n=1;
    else
    n=-1;

Console.WriteLine("m={0}",m);
Console.WriteLine("n={0}",n);

opg 11

int a,b,c;

double d, x1,x2;

Console.Write("\n\n");

Console.Write("Input value a : ");
    a=Convert.ToInt32(Console.ReadLine());

Console.Write("Input value b : ");
    b=Convert.ToInt32(Console.ReadLine());

Console.Write("Input value c : ");
    c=Convert.ToInt32(Console.ReadLine());

d=b*b-4*a*c;
if(d==0)
   {
     Console.Write("Both roots are equal.\n");
     x1=-b/(2.0*a);
     x2=x1;
     Console.Write("First  Root Root1= {0}\n",x1);
     Console.Write("Second Root Root2= {0}\n",x2);
   }
   else if(d>0)
	{
	   Console.Write("Both roots are real and diff-2\n");

	   x1=(-b+Math.Sqrt(d))/(2*a);
	   x2=(-b-Math.Sqrt(d))/(2*a);

	   Console.Write("First  Root Root1= {0}\n",x1);
	   Console.Write("Second Root root2= {0}\n",x2);
	}
	else
	    Console.Write("Root are imeginary;\nNo Solution. \n\n");

opg 12

double num,phy,math,ca,total,per;
string name,div=null;

Console.WriteLine("\n\n");
    Console.WriteLine("input roll number of student");
num=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input name of student");
name=Console.ReadLine();

Console.WriteLine("input the marks for physics");
phy=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input the marks of math");
math=Convert.ToDouble(Console.ReadLine());
Console.Write("Input the marks of Computer Application : ");
ca = Convert.ToDouble(Console.ReadLine());

total=phy+math+ca;

per=total/3;

if(per>60)
    div="first";

else if(per<=60)
if(per>48)
    div="second";

else if(per<=48)
if(per>=36)
    div="pass";

else
    div="fail";

Console.Write("\nRoll No : {0}\nName of Student : {1}\n",num,name);
Console.Write("Marks in Physics : {0}\nMarks in Math : {1}\nMarks in Computer Application : {2}\n",phy,math,ca);
Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n",total,per,div);

opg 13

int temp;

Console.WriteLine("\n\n");
    Console.WriteLine("input a temperature");
        temp=Convert.ToInt32(Console.ReadLine());

if(temp<=0)
    Console.WriteLine("If you go outside you will be like brbrrbrr");

else if(temp<=10)
    Console.WriteLine("You will freez a bit");

else if(temp<=20)
    Console.WriteLine("its a tiny cold");

else if(temp<=30)
    Console.WriteLine("its meh weather");

else if(temp<40)
    Console.WriteLine("no shirt lets gooo");

else if(temp>=40)
    Console.WriteLine("dont go out in the sun");
*/

