using Roman = example.RomanNumerals;
using TF = TestFraemwork.TestFraemwork; // Creating a alias (shorter name) for the testing framwork.


TF.Test<Type>(typeof(string), Roman.Convert(1).GetType(), "Return type is string");


TF.Test<string>("I", Roman.Convert(1), "Converting integer value to roman numeral");
TF.Test<string>("II", Roman.Convert(2), "Converting integer value to roman numeral");

// Note that because we created an overloaded Test method we can simply write 
TF.Test("IV", Roman.Convert(4), "Converting integer value to roman numeral");
TF.Test("V", Roman.Convert(5), "Converting integer value larger than or equal to 5");
TF.Test("VII", Roman.Convert(7), "Converting integer value larger than or equal to 5");

TF.Test("IX", Roman.Convert(9), "Converting integer, 10 border");
TF.Test("X", Roman.Convert(10), "Converting integer, 10 border");
TF.Test("XIII", Roman.Convert(13), "Converting integer, 10 border");
TF.Test("XXIV", Roman.Convert(24), "Converting integer, above 20");
TF.Test("XXXVI", Roman.Convert(36), "Converting integer, above 30");


TF.Test("XLVIII", Roman.Convert(48), "Converting integer, 50 border");
TF.Test("LVI", Roman.Convert(56), "Converting integer, 50 border");

TF.Test("CMXLV", Roman.Convert(945), "Converting larger number");