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
                break;
            case MenuHelpers.GroupTicket:
                break;
            case MenuHelpers.ThirdWord:
                break;
            case MenuHelpers.Quit:
                isOpen = false;
                break;
            default:
                break;
        }

    } while (isOpen);
}

RenderMainMenu();
