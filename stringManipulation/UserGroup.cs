namespace stringManipulation
{
    public class UserGroup
    {
        private List<User> userGroup { get; set; }

        public UserGroup()
        {
            userGroup = new List<User>();
        }

        internal void AddUserToList(int age)
        {
            userGroup.Add(new User(age));
        }

        internal (IEnumerable<User> users, int totalTickets, int totalPrice) GetUserGroupInformation()
        {
            int totalTickets = userGroup.Count; // Number of tickets is the count of users
            int totalPrice = userGroup.Sum(user => user.TicketPrice); // Calculate total price of all tickets

            return (userGroup.ToArray(), totalTickets, totalPrice);
        }

        public void DisplayUserGroupInformation()
        {
            var (users, totalTickets, totalPrice) = GetUserGroupInformation();


            Utils.InfoConsoleColor();
            foreach (User user in users)
            {
                Console.WriteLine(user); // call the overridden ToString() 
            }

            Console.WriteLine($"Total Tickets: {totalTickets}");
            Console.WriteLine($"Total Price: {totalPrice}");
            Utils.DefaultConsoleColor();
        }
    }
}
