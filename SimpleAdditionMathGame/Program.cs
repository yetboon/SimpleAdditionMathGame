﻿using System;

namespace SimpleAdditionMathGame
{
	class Program
	{
		
		//This can let u generate a random number by using its method :D
		public static Random r = new Random();
		
		public static void Main(string[] args)
		{
			
			//The scoreboard that records user's answer is correct or not.
			int answerCorrect = 0;
			
			//This will infinite loop...
			while(true)
			{
				//Set up the question A & B , their number will be generated by Random class.
				//The number is 1 ~ 99
				int qA = r.Next(1,10);
				int qB = r.Next(1,10);
				
				//Write down the question to the user
				Console.WriteLine("{0} + {1} = " ,qA,qB);
				
				//Get the user's answer("string") and convert to ("int") !
				int answer = Convert.ToInt32(Console.ReadLine());
				
				//Check the answer,and add the score into "answerCorrect" !
				if(answer == (qA + qB))
				{
					answerCorrect++;
				}
				
				//Clear the console text
				Console.Clear();
				//and print out the score user have
				Console.WriteLine("You have corrected {0} answers !",answerCorrect);
			}
		}
	}
}