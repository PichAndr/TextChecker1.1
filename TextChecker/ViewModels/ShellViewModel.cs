namespace TextChecker.ViewModels
{
    using System.Collections.Generic;
    using Caliburn.Micro;
    public class ShellViewModel : Conductor<object>
    {
        public void LoadPalindrome()
        {
            ActivateItem( new PalindromeViewModel() );
        }
        public void LoadEvenOrOdd()
        {
            ActivateItem( new EvenOrOddViewModel() );
        }
        public void LoadPrimeNumber()
        {
            ActivateItem( new PrimeNumberViewModel() );
        }

 
    }
}