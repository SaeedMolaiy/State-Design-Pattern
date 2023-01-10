using System;
using State.Models;

namespace State
{
    internal class Program
    {
        static void Main()
        {
            // The client code.
            var messageBox = new MessageBox(new ErrorMessageBox());

            messageBox.ShowDialog();

            messageBox.SetMessageBox(new SuccessMessageBox());
            messageBox.ShowDialog();

            Console.ReadKey();
        }
    }
}
