using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Array
{
    // - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

    //If no one likes your post, it doesn't display anything.
    //If only one person likes your post, it displays: [Friend's Name] like your post.
    //If two people like your post, it displays: [Friend 1] and[Friend 2] likes your post.
    //If more than two people like your post, it displays: [Friend 1], [Friend 2]
    //and[Number of Other People] others like your post.
    //Write a program and continuously ask the user to enter different names,
    //until the user presses Enter (without supplying a name). Depending on the number
    //of names provided, display a message based on the above pattern.
    public class Ex1
    {
        public static void DisplayText()
        {
            string input;
            string[] likePosts = new string[99];
            int count = 0;

            do
            {
                Console.WriteLine("Enter different names: ");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    likePosts[count++] = input;
                } else
                {
                    break; ;
                }
            }
            while (true);

            if (count == 0)
            {

            }
            else if (count == 1)
            {
                Console.WriteLine(likePosts[0] +  " like your photo");
            } else if (count == 2)
            {
                Console.WriteLine(likePosts[0] + " and " + likePosts[1] + " like your photo");
            } else
            {
                Console.WriteLine(likePosts[0] + ", " + likePosts[1] + " and " + (count - 2) + " others like your post");
            }

            
        }

    }
}
