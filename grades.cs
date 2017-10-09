using System;

class Grades
{
  static void Main()
  {
    Console.WriteLine ("What grade did you average in all of your classes? (A/B/C/D/F)");
    string grade = Console.ReadLine().ToUpper();

    bool grade1 = grade == "A";
    bool grade2 = grade == "B";
    bool grade3 = grade == "C";

    if (grade1 || grade2) {
      Console.WriteLine("Why didn't you get 100%?");
    }
    else if (grade3) {
      Console.WriteLine("...You can do better than this.");
    }
    else {
      Console.WriteLine("YOU ARE NEVER GOING OUT AGAIN!");
    }
  }
}
