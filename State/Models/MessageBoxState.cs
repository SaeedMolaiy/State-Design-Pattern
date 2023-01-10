namespace State.Models
{
    // The base State class declares methods that all Concrete State should
    // implement and also provides a backreference to the Context object,
    // associated with the State. This backreference can be used by States to
    // transition the Context to another State.
    public abstract class MessageBoxState
    {

        protected MessageBox MessageBox;

        public void SetContext(MessageBox messageBox)
        {
            MessageBox = messageBox;
        }

        public abstract void ShowDialog();
    }
}
