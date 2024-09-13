namespace stringManipulation
{
    public class SinemaTicketPice
    {
        public const int ChildAgeLimit = 5;
        public const int JuniorAgeLimit = 20;
        public const int SeniorAgeLimit = 64;
        public const int SuperSeniorAgeLimit = 100;

        public const int JuniorPrice = 80;
        public const int SeniorPrice = 90;
        public const int StandartPrice = 120;

        public bool IsChild(int age) => age >= 0 && age < ChildAgeLimit;
        public bool IsJunior(int age) => age >= ChildAgeLimit && age < JuniorAgeLimit;
        public bool IsAdult(int age) => age >= JuniorAgeLimit && age <= SeniorAgeLimit;
        public bool IsSenior(int age) => age >SeniorAgeLimit && age <= SuperSeniorAgeLimit;
        public bool IsSuperSenior(int age) => age >SuperSeniorAgeLimit;


    }


}