Console.WriteLine("Hello, World!");

// My Hero Details:

string heroName = "Naruto";
int heroHeight = 178;
int heroAge = 26;
string heroSuperPower = "Tailed Beast Bomb RasenShuriken";

// The villain details

string villainName = "Sasuke";
int villainNHeight = 175;
int villainAge = 27;
string villainNSuperPower = "Inferno Style Flame Control";


int ageDifference= villainAge - heroAge;

Console.WriteLine("The hero in this story is " + heroName+ "\n" +
"He's age is " + heroAge +"\n"+
    "and He's " + heroHeight + "cm"+ "\n"+
"Also, don't forget his supr power " + heroSuperPower + "\n"
);

Console.WriteLine( "Our story has a villain as well. He is " +
    villainName + "\n" +
    "He is " + villainAge + " old and " + villainNHeight + " height"+"\n"
+ "As our hero, the villain also have super power and it named" +
villainNSuperPower
);

heroHeight = heroHeight + 5;
villainNSuperPower = "None";

Console.WriteLine("The hero in this story is " + heroName + "\n" +
"He's age is " + heroAge + "\n" +
    "and He's " + heroHeight + "cm" + "\n" +
"Also, don't forget his supr power " + heroSuperPower + "\n"
);

Console.WriteLine("Our story has a villain as well. He is " +
    villainName + "\n" +
    "He is " + villainAge + " old and " + villainNHeight + " height" + "\n"
+ "As our hero, the villain also have super power and it named" +
villainNSuperPower
);