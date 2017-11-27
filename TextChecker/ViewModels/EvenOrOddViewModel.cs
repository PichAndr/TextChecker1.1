namespace TextChecker.ViewModels
{
    using System;
    using System.Text.RegularExpressions;
    public class EvenOrOddViewModel : BaseViewModel
    {
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged( Text );
            }
        }

        public string TextBlockMessage
        {
            get
            {
                return _textBlockMessage;
            }
            set
            {
                _textBlockMessage = value;
                OnPropertyChanged( "textBlockMessage" );

            }
        }
        public void HaveResult()
        {
            if( string.IsNullOrWhiteSpace( Text ) )
            {
                TextBlockMessage = "Bitte geben Sie einen Zahl ein";
            }
            else if( Text != null )
            {
                Regex zahl = new Regex( "^[0-9]+$" );
                if( zahl.IsMatch( Text.TrimStart() ) )
                {
                    int valueZahl = Int32.Parse( Text );
                    if( valueZahl % 2 == 0 )
                    {
                        TextBlockMessage = "Ihre Eingabe ist eine gerade Zahl";
                    }
                    else
                    {
                        TextBlockMessage = "Ihre Eingabe ist eine ungerade Zahl";
                    }

                }
                else
                {
                    TextBlockMessage = "ungültige Eingabe!\nBitte eine Zahl eingeben";
                }
            }


        }
        private string _text;
        private string _textBlockMessage;
    }
}

