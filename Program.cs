using System;
using System.Collections;
using System.Linq;              // Uniform querry syntax for working with data
using algorithmsCSharp;
using algorithmsC1;
using algorithmsC2;
using algorithmsC3;
using algorithmsC4;
using algorithmsC5;
using algorithmsC6;
using algorithmsC7;
using algorithmsC8;
using algorithmsC10;

namespace algorithmsC_
{
    class Program
    {
        static int findMaximum(int a, int b, int c) {
            int max = a;

            if(b > max) { max = b; }

            if(c > max) { max = c; }

            return max;
        }

        static Boolean IsUppercase(string s){
            return s.All(char.IsUpper); // .All() returns boolean based on parameter condition
        }

        static Boolean IsLowercase(string s){
            return s.All(char.IsLower); // .All() returns boolean based on parameter condition
        }

        static Boolean IsPasswordComplex(string s){
            return s.Any(char.IsLower) && s.Any(char.IsUpper) && s.Any(char.IsDigit); // .Any() returns boolean based on parameter condition
        }

        static string NormalizeString(string input){
            return input.ToLower().Trim().Replace(",", "");
        }

        // Check if an item index is even
        static Boolean IsAtEvenIndex(string s, char item) {
            if(String.IsNullOrEmpty(s)) { return false; }

            for (int i = 0; i < s.Length / 2 + 1; i+=2) {
                if(s[i] == item) { return true; }
            }
            return false;
        }

        /***************************************************************
        * Aggregate and Flter Arrays
        ***************************************************************/
        static int[] FindEvenNums(int[] arr1, int[] arr2) {
            ArrayList result = new ArrayList();

            foreach(int num in arr1) {
                if(num % 2 == 0) {
                    result.Add(num);
                }
            }

            foreach(int num in arr2) {
                if(num % 2 == 0) {
                    result.Add(num);
                }
            }

            return (int[])result.ToArray(typeof(int));
        }

        

        static void Main(string[] args)
        {
            // int[] arr = {1, 2, 4, 5, 6, 8};
            // Console.WriteLine("Function call: " + CustomReverseArray.ReverseInPlace(arr));
            // RotateInPlaceRight(arr);
            // CustomReverseArray.RotateInPlaceLeft(arr);
            // Array.ForEach(arr, Console.WriteLine);

            // CustomLinkedList linkedList = new CustomLinkedList();
            // CustomLinkedList.Node firstNode = new CustomLinkedList.Node(3);
            // CustomLinkedList.Node secondNode = new CustomLinkedList.Node(4);
            // CustomLinkedList.Node thirdNode = new CustomLinkedList.Node(5);
            // CustomLinkedList.Node fourthNode = new CustomLinkedList.Node(6);
            // CustomLinkedList.Node fifthNode = new CustomLinkedList.Node(7);

            // linkedList.head = firstNode;
            // firstNode.next = secondNode;
            // secondNode.next = thirdNode;
            // thirdNode.next = fourthNode;
            // fourthNode.next = fifthNode;

            // linkedList.displayContent();
            // linkedList.deleteKthNodeFromEnd(2);
            // Console.WriteLine();
            // linkedList.displayContent();

            // CustomQueue.printBinary(5);

            // CustomStack.printNextGreaterElement(arr);
            // CustomHashSet.supposedFx3();

            /**************************************
            * POLYMORPHISM
            **************************************/
            const int hours = 50, wage = 70;

            Polymorphism.Employee person = new Polymorphism.Employee();
            person.CalculateWeeklySalary(hours, wage);

            Polymorphism.Contractor contractor = new Polymorphism.Contractor();
            contractor.CalculateWeeklySalary(hours, wage);
        }
    }
}
