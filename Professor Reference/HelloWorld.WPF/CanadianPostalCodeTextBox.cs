using System.Windows.Controls;
using System.Windows.Input;

namespace HelloWorld
{
    public class CanadianPostalCodeTextBox : TextBox
    {
        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            e.Handled = !IsValidPostalCode(e.Text, CaretIndex);
            base.OnPreviewTextInput(e);
        }

        private bool IsValidPostalCode(string proposedText, int caretIndex)
        {
            // letter-number-letter-text
            var currentText = Text + proposedText;

            if (currentText.Length > 6)
            {
                return false;
            }

            var needLetter = true;

            foreach (var ch in currentText)
            {
                if (needLetter && !char.IsLetter(ch))
                {
                    return false;
                }
                if (!needLetter && !char.IsDigit(ch))
                {
                    return false;
                }

                needLetter = !needLetter;
            }

            return true;
        }
    }
}
