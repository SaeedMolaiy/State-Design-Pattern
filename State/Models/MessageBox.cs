namespace State.Models
{
    // The Context defines the interface of interest to clients. It also
    // maintains a reference to an instance of a State subclass, which
    // represents the current state of the Context.
    public class MessageBox
    {
        // A reference to the current state of the Context.
        private MessageBoxState _messageBox;

        public MessageBox(MessageBoxState messageBox)
        {
            _messageBox = messageBox;
        }

        // The Context allows changing the State object at runtime.
        public void SetMessageBox(MessageBoxState messageBox)
        {
            _messageBox = messageBox;
        }

        // The Context delegates part of its behavior to the current State
        // object.
        public void ShowDialog()
        {
            _messageBox.ShowDialog();
        }
    }
}