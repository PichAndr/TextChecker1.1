

namespace TextChecker.ViewModels
{
    using System;
    using System.Text.RegularExpressions;
    public class PrimeNumberViewModel : BaseViewModel
    {
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged(Text);
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
                OnPropertyChanged("textBlockMessage");

            }
        }
        public void HaveResult()
        {

            if (string.IsNullOrWhiteSpace(Text))
            {
                TextBlockMessage = "Bitte geben Sie einen Zahl ein";
            }
            else if (Text != null)
            {

                Regex zahl = new Regex("^[0-9]+$");
                if (zahl.IsMatch(Text.TrimStart()))
                {
                    bool result = Int32.TryParse(Text, out int valueZahl);

                    if (valueZahl == 3 || valueZahl == 5 || valueZahl == 7)
                    {
                        TextBlockMessage = "Ihre Eingabe " + valueZahl + " ist eine Primzahl";
                    }
                    else if (valueZahl == 1 || valueZahl == 9)
                    {
                        TextBlockMessage = "Ihre Eingabe " + valueZahl + " ist keine Primzahl";
                    }

                    if (valueZahl % 2 != 0)
                    {
                        for (int i = 3; i < Math.Sqrt(valueZahl); i += 2)
                        {
                            if (valueZahl % i == 0)
                            {
                                TextBlockMessage = "Ihre Eingabe " + valueZahl + " ist keine Primzahl";
                                break;
                            }
                            else
                            {
                                TextBlockMessage = "Ihre Eingabe " + valueZahl + " ist eine Primzahl";
                            }
                        }
                    }
                    else
                    {
                        if (valueZahl == 2)
                        {
                            TextBlockMessage = "Ihre Eingabe " + valueZahl + " ist eine Primzahl";
                        }
                        else
                        {
                            TextBlockMessage = "Ihre Eingabe " + valueZahl + " ist keine Primzahl";
                        }

                    }
                }
                else
                {
                    TextBlockMessage = "ungültige Eingabe!\nBitte nur eine Zahl eingeben";
                }

            }
        }
        private string _text;
        private string _textBlockMessage;
    }
}








