namespace DesignMode.MediatorPattern
{
    public class User
    {
        private string name;

        public User(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string sendMessage(string message)
        {
            return ChatRoom.showMessage(this, message);
        }
    }
}