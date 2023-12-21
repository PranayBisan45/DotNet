using HR;
using Graphics;

Boolean status=false;

char ch='u';
int count=56;
count ++;
int [] arr={34,76,67,45};

string fullName="Pranay Bisan";

Console.WriteLine(fullName);
Console.WriteLine("Hello, World!");

if(count >=100){
    Console.WriteLine("Your are extraordinary");
}
else{
    Console.WriteLine("Your are  ordinary");
}
for(int i=0;i<arr.Length;i++){
      Console.WriteLine(arr[i]);
}

Person prn=new Person(45, "Pranay", "Bisan");
string objFirstName=prn.FirstName();
prn.LastName="Bisane";
string antotherLastName=prn.LastName;
string strPerson=prn.ToString();
Console.WriteLine(strPerson);

Color myColor=new Color(255,0,0);

