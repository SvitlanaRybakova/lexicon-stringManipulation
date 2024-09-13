namespace stringManipulation
{
    public class User
    {
        public enum UserGroup
        {
            Child,
            Junior,
            Adult,
            Senior,
            Super_Senior
        }
        public int Age { get; set; }
        public string Group { get; set; }
        public int TicketPrice { get; set; }

        public User(int age)
        {
            Age = age;

            if (CinemaTicketPice.IsChild(age))
            {
                Group = UserGroup.Child.ToString();
                TicketPrice = CinemaTicketPice.FreeTicket;
            }
            else if (CinemaTicketPice.IsJunior(age))
            {
                Group = UserGroup.Junior.ToString();
                TicketPrice = CinemaTicketPice.JuniorPrice;
            }
            else if (CinemaTicketPice.IsAdult(age))
            {
                Group = UserGroup.Adult.ToString();
                TicketPrice = CinemaTicketPice.StandardPrice;
            }
            else if (CinemaTicketPice.IsSenior(age))
            {
                Group = UserGroup.Senior.ToString();
                TicketPrice = CinemaTicketPice.SeniorPrice;
            }
            else if (CinemaTicketPice.IsSuperSenior(age))
            {
                Group = UserGroup.Super_Senior.ToString();
                TicketPrice = CinemaTicketPice.FreeTicket;
            }
            else
            {
                Utils.PrintErrorMessage("Please enter a valid age");
            }
        }

        public override string ToString()
        {
            return $"Age: {Age}, Group: {Group}, Ticket Price: {TicketPrice}";
        }

        public void DisplayUserInformation()
        {
            Utils.PrintInfoMessage(this.ToString());

            // Utils.InfoConsoleColor();
            // Console.WriteLine(this); // call the overridden ToString() and this.user
            // Utils.DefaultConsoleColor();
        }
    }
}
