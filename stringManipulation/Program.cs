// See https://aka.ms/new-console-template for more information

using stringManipulation;

void RenderMainMenu()
{
    bool isOpen = true;

    do
    {

        MenuHelpers.ShowMainMenu();

        string input = Console.ReadLine();

        switch (input)
        {
            case MenuHelpers.SinemaMenu:
                RenderSinemaMenu();
                break;
            case MenuHelpers.Repeat:

                break;
            case MenuHelpers.ThirdWord:

                break;
            case MenuHelpers.Quit:
                isOpen = false;
                break;
            default:
                MenuHelpers.InvalidVal();
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

        string input = Console.ReadLine();

        switch (input)
        {
            case MenuHelpers.SingleTicket:
                CalculateTheSingleTicket();
                break;
            case MenuHelpers.GroupTicket:
                CalculateTheGroupTicket();
                break;
            case MenuHelpers.ThirdWord:
                break;
            case MenuHelpers.Quit:
                isOpen = false;
                break;
            default:
                MenuHelpers.InvalidVal();
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
        Console.WriteLine(user);
    }
    else
    {
        Console.WriteLine("Please enter a valid age");
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
                            Console.WriteLine("Please enter a valid age");
                        }
                        break;

                    case "no":
                      
                        group.AddUserToList(age);  
                        group.DisplayUserGroupInformation();
                        isContinue = false;
                        isOpen = false; 
                        break;

                    default:
                    
                        MenuHelpers.InvalidVal();
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

RenderMainMenu();
