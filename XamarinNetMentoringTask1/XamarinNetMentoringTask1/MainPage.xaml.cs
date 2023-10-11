using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinNetMentoringTask1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SayHelloButton_Clicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text; // Get the user's name from the Entry control

            if (string.IsNullOrWhiteSpace(name))
            {
                greetingLabel.Text = "Please enter your name.";
            }
            else if (name.Contains("e"))
            {
                greetingLabel.Text = CustomLibraryTask1.CustomGreetings.GetGreeting(name);
            }
            else
            {
                string greeting = $"Hello, {name}!";
                greetingLabel.Text = greeting;
            }
        }
    }
}

