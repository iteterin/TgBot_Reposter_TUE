using TgBot_Reposter_TUE;
using Terminal.Gui;

Application.Init();

try
{
    Application.Run(new MyView());
}
finally
{
    Application.Shutdown();
}