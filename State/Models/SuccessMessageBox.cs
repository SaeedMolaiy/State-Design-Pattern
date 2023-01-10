using System;

namespace State.Models
{
    // Concrete States implement various behaviors, associated with a state of
    // the Context.
    public class SuccessMessageBox : MessageBoxState
    {
        public override void ShowDialog()
        {
            //  you can change context state like this
            //  MessageBox.SetMessageBox(new ErrorMessageBox());

            Console.WriteLine($"Success Message");
        }
    }
}
