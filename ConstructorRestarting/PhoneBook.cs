namespace ConstructorRestarting
{
    class PhoneBook
    {
        public string name, address, email;
        public int number;

        public PhoneBook()
        {
            name = "";
            address = "";
            email = "";
            number = 0;
        }

        public PhoneBook(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public PhoneBook(string name, string email, int number)
        {
            this.name = name;
            this.email = email;
            this.number = number;
        }

        public PhoneBook(string name, string email, string address, int number)
        {
            this.name = name;
            this.email = email;
            this.address = address;
            this.number = number;
        }
    }
}
