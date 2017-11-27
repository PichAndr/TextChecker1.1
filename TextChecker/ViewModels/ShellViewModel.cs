namespace TextChecker.ViewModels
{
    using Caliburn.Micro;
    using System.Collections.Generic;

    public class ShellViewModel : Conductor<object>.Collection.OneActive
    {

        public void LoadPalindrome()
        {
            ActivateItem(new PalindromeViewModel());
        }
        public void LoadEvenOrOdd()
        {
            ActivateItem(new EvenOrOddViewModel());
        }
        public void LoadPrimeNumber()
        {
            ActivateItem(new PrimeNumberViewModel());
        }

        //public List<object> Checkers = new List<object>()
        //{
        //    new PalindromeViewModel(), new EvenOrOddViewModel(), new PrimeNumberViewModel()
        //};
    }
    
}   

