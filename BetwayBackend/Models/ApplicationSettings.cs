namespace BetwayBackend.Models
{
    public class ApplicationSettingsGeneral
    {

        public  string[] BannerOptions { get; set; } = { "sports","live & real","casino","esports","vegas"};

        public  string Login { get; set; } = "Login";

        public  string SignUp { get; set; } = "Sign up";

        public  string[] FooterLines { get; set; } = { "SPORTS NEW CUSTOMER OFFER", "Get up to $10 in Free Bets", "Join Now" };


    }

    public  class ApplicationSettingsCTALogin
    {

        public  string[] HeaderText { get; set; } = { "Login", "New customer?", "Register here" };

        public  string[] FormFields { get; set; } = { "Username", "Password" };

        public  string[] FooterText { get; set; } = { "Login", "Forgot Username/Password" };

    }

}
