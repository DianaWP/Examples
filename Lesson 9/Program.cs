using System;
using System.Collections.Generic;

namespace Lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var textbook1 = new TextBook {
                Subject ="Programming",
                Author = "Bjarne",
                Title  = "Programming Principles and Practice" 
                
            }; 

            
    

            var textbook = new List<TextBook> {
                textbook1,  
            };

            foreach (var textbook in textbook) {
                textbook.DisplayDetails(); 
            };



        
        }

    

    
            
        
    }
}