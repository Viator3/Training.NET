namespace InheritanceTest
{
    class User
    {
        public string name;
        public string login;
        public string pass;
        public int Level { get; set; } = 2;

        public static bool operator >(User a, User b)
        {
            return (a.Level < b.Level);
        }

        public static bool operator <(User a, User b)
        {
            return (a.Level > b.Level);
        }
    }

    class Manager : User
    {
        public string phone;
        public new int Level { get; set; } = 1;
    }

    class Administrator : Manager
    {
        public string position;
        public new int Level { get; set; } = 0;
    }
}
