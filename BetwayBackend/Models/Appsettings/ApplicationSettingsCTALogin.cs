namespace BetwayBackend.Models.Appsettings
{
    public class ApplicationSettingsCTALogin
    {
        public string[] HeaderText { get; set; } = { "Login", "New customer?", "Register here" };

        public string[] FormFields { get; set; } = { "Username", "Password" };

        public string[] FooterText { get; set; } = { "Login", "Forgot Username/Password" };

        public string[] WelcomeUser { get; set; } = { "Success", "Welcome", "Continue" };
    }
}