
//------------------------------------------------------------------------------

//  <auto-generated>
//      This code was generated by:
//        TerminalGuiDesigner v1.0.17.0
//      You can make changes to this file and they will not be overwritten when saving.
//  </auto-generated>
// -----------------------------------------------------------------------------
namespace TgBot_Reposter_TUE
{
    using Terminal.Gui;
    using System;
    using System.Security.Principal;

    public partial class MyView {

        public MyView()
        {
            InitializeComponent();

            var user = WindowsIdentity.GetCurrent().User;
            var userName = user.Translate(typeof(NTAccount)).ToString();

            //button1.Accept += (s, e) => MessageBox.Query("Hello", "Hello There!", "Ok");
            labelText_username.Text = userName;
        }
    }
}
