namespace stringManipulation
{
    public static class CinemaTicketPice
    {
        public const int ChildAgeLimit = 5;
        public const int JuniorAgeLimit = 20;
        public const int SeniorAgeLimit = 64;
        public const int SuperSeniorAgeLimit = 100;

        public const int FreeTicket = 0;
        public const int JuniorPrice = 80;
        public const int SeniorPrice = 90;
        public const int StandardPrice = 120;


        public static bool IsChild(int age) => age >= 0 && age < ChildAgeLimit;
        public static bool IsJunior(int age) => age >= ChildAgeLimit && age < JuniorAgeLimit;
        public static bool IsAdult(int age) => age >= JuniorAgeLimit && age <= SeniorAgeLimit;
        public static bool IsSenior(int age) => age > SeniorAgeLimit && age <= SuperSeniorAgeLimit;
        public static bool IsSuperSenior(int age) => age > SuperSeniorAgeLimit;


    }


}
