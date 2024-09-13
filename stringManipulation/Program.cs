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

RenderMainMenu();
