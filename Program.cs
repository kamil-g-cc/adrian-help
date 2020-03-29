using System;

namespace adrian_help
{
    //FIXME: move to the separate file
    class Hand : IComparable<Hand>, IEquatable<Hand>
    {
        /*
            return -1, 0 or 1 depends if something is greater or smaller or equal during comparison
        */
        public int CompareTo([System.Diagnostics.CodeAnalysis.AllowNull] Hand other){
            //TODO: implment CompareTo method in Hand class
            return 0;
        }
        public bool Equals([System.Diagnostics.CodeAnalysis.AllowNull] Hand other){
            //TODO: implement Equals method in Hand class
            return false;
        }
        public Hand()
        {

        }
    }
    //FIXME: move to the separate file 
    class Gambler : Hand
    {
        //TODO: find a better spot for placing the amount of default Money
        //although could be actually the best place to set this variable
        //this is not stated in UML.
        private static int DefaultStartMoney = 5000; 
        int Money {get;set;}
        public Gambler()
        {
            Money = DefaultStartMoney;
        }
        public Gambler(int startMoney)
        {
            Money = startMoney;
        }
        public bool isBroken(){
            return Money == 0;
        } 

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
