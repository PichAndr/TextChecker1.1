namespace TextChecker.ViewModels
{
    using System.Text.RegularExpressions;
    public class PalindromeViewModel : ViewModelBase
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

            string tempText = "";
            if( string.IsNullOrWhiteSpace( Text ) )
            {
                TextBlockMessage = "Bitte geben Sie einen Text ein";
            }
            else
            {
                string value = Regex.Replace( Text, "[^a-zA-Z]+", string.Empty );
                for( int i = value.Length - 1; i >= 0; i-- )
                {
                    tempText = tempText + value[i];
                }
                if( value == "" )
                {
                    TextBlockMessage = "ungültige Eingabe!\nBitte einen Text ein";
                }
                else if( string.Equals( value, tempText, System.StringComparison.OrdinalIgnoreCase ) )
                {
                    TextBlockMessage = "Ihre Eingabe ist ein Palindrom";
                }
                else
                {
                    TextBlockMessage = "Ihre Eingabe ist kein Palindrom";
                }

            }
        }
        private string _text;
        private string _textBlockMessage;
    }
}

