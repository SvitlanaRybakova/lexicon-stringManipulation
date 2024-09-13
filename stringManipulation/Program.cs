// See https://aka.ms/new-console-template for more information

using System.Text;
using stringManipulation;

void RenderMainMenu()
{
    bool isOpen = true;

    do
    {

        MenuHelpers.ShowMainMenu();

        string input = Console.ReadLine() ?? string.Empty;

        switch (input)
        {
            case MenuHelpers.SinemaMenu:
                RenderSinemaMenu();
                break;
            case MenuHelpers.Repeat:
                RepeatTenTimes();
                break;
            case MenuHelpers.ThirdWord:
                GetThirdWord();
                break;
            case MenuHelpers.Quit:
                isOpen = false;
                break;
            default:
                Utils.PrintErrorMessage("Invalid menu value, please enter the correct menu number");
                break;
        }

    } while (isOpen);
}

void RenderSinemaMenu()
{
    bool isOpen = true;

    do
    {
        MenuHelpers.ShowSinemaMenu();

        string input = Console.ReadLine() ?? string.Empty;

        switch (input)
        {
            case MenuHelpers.SingleTicket:
                CalculateTheSingleTicket();
                break;
            case MenuHelpers.GroupTicket:
                CalculateTheGroupTicket();
                break;
            case MenuHelpers.Quit:
                isOpen = false;
                break;
            default:
                Utils.PrintErrorMessage("Invalid menu value, please enter the correct menu number");
                break;
        }

    } while (isOpen);
}

void CalculateTheSingleTicket()
{
    string input = Utils.AskForString("Enter the user age");

    if (int.TryParse(input, out int result))
    {
        User user = new User(result);
        user.DisplayUserInformation();
    }
    else
    {
        Utils.PrintErrorMessage("Please enter a valid age");
    }

}


void CalculateTheGroupTicket()
{
    bool isOpen = true;
    do
    {
        // Ask for the user's age
        string input = Utils.AskForString("Enter the user age");
        UserGroup group = new UserGroup();

        if (int.TryParse(input, out int age))
        {
            bool isContinue = true;
            do
            {
                // Ask if they want to continue adding users
                string askForContinue = Utils.AskForString("Do you want to buy more tickets? (yes/no)");

                switch (askForContinue.ToLower())
                {
                    case "yes":
                        group.AddUserToList(age);

                        string newAgeInput = Utils.AskForString("Enter the user age");
                        if (int.TryParse(newAgeInput, out int newAge))
                        {
                            age = newAge;
                        }
                        else
                        {
                            Utils.PrintErrorMessage("Please enter a valid age");

                        }
                        break;

                    case "no":

                        group.AddUserToList(age);
                        group.DisplayUserGroupInformation();
                        isContinue = false;
                        isOpen = false;
                        break;

                    default:
                        Utils.PrintErrorMessage("Invalid menu value, please enter the correct one");
                        break;
                }

            } while (isContinue);

        }
        else
        {
            Console.WriteLine("Please enter a valid age");
        }

    } while (isOpen);
}

void RepeatTenTimes()
{
    const int RepeatedTimes = 10;
    string input = Utils.AskForString("Enter any phrase");

    StringBuilder builder = new StringBuilder();

    for (int i = 1; i <= RepeatedTimes; i++)
    {
        builder.Append($"{i}.{input}; ");
    }

    Utils.PrintInfoMessage(builder.ToString());
}

void GetThirdWord()
{
    string input = Utils.AskForString("Please enter a sentence with exactly 3 words");
    string[] words = input.Split(' ');

    if (words.Length == 3)
    {
        string thirdWord = words[2];
        Utils.PrintInfoMessage($"The third word is: {thirdWord}");
    }
    else
    {
        Utils.PrintErrorMessage("The sentence does not contain exactly 3 words.");
    }
}
RenderMainMenu();
