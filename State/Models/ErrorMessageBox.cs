using System;

namespace State.Models
{
    // Concrete States implement various behaviors, associated with a state of
    // the Context.
    public class ErrorMessageBox : MessageBoxState
    {
        public override void ShowDialog()
        {
            Console.WriteLine($"Error Message");
        }
    }
}
