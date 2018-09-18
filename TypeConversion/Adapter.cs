namespace TypeConversion
{
    class Adapter
    {
        public int Level;

        public static explicit operator Adapter(User user)
        {
            return new Adapter { Level = user.Level };
        }

        public static explicit operator Adapter(Administrator administrator)
        {
            return new Adapter { Level = administrator.Level };
        }

        //public static implicit operator Adapter(User user)
        //{
        //    Adapter adapter = new Adapter();
        //    adapter.Level = user.Level;
        //    return adapter;
        //}
    }

    class User
    {
        public string name;
        public string login;
        public string pass;
        public int Level { get; set; } = 2;

        public static explicit operator User(Adapter adapter)
        {
            return new User { Level = adapter.Level };
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

        public static explicit operator Administrator(Adapter adapter)
        {
            return new Administrator { Level = adapter.Level };
        }
    }
}
