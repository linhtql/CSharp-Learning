

//var fullname = "tran quang linh";
//console.writeline("trim: {0}", fullname.trim());
//console.writeline("toupper: {0}", fullname.toupper());

//var index = fullname.indexof(' ');
//var firstname = fullname.substring(0, index);
//var lastname = fullname.substring(index + 1);
//console.writeline("first name: {0}", firstname);
//console.writeline("last name: {0}", lastname);
//var names = fullname.split(' ');
//console.writeline("first name: " + names[0]);
//console.writeline("last name: " + names[1]);

//console.writeline(fullname.replace("linh", "hoa"));

//if (!string.isnullorempty(fullname))
//{
//    console.writeline("invalid!");
//}

//var str = "25";
//var age = convert.tobyte(str);
//console.writeline(age);

//float price = 29.95f;
//price.tostring("c0");
//console.writeline(price.tostring("c0"));

using String;

var sentence = "This is going to be a really really really long text.";
        string summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);

