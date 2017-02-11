namespace BikeSharing.Clients.Core
{
    public static class GlobalSettings
    {
        public const string AuthenticationEndpoint = "http://bikesharing-services-profilesqyvqvnoyiaenw.azurewebsites.net/";
        public const string EventsEndpoint = "http://bikesharing-services-eventsqyvqvnoyiaenw.azurewebsites.net/";
        public const string IssuesEndpoint = "http://bikesharing-services-feedbackqyvqvnoyiaenw.azurewebsites.net/";
        public const string RidesEndpoint = "http://bikesharing-services-ridesqyvqvnoyiaenw.azurewebsites.net/";

        public const string OpenWeatherMapAPIKey = "f0944223b33f8e0965afb381ce3f8753";

        public const string HockeyAppAPIKeyForAndroid = "40b21ba899384cca9171df1f242c4754";
        public const string HockeyAppAPIKeyForiOS = "YOUR_HOCKEY_APP_ID";

        public const string SkypeBotAccount = "skype:YOUR_BOT_ID?chat";

        public const string BingMapsAPIKey = "AjHU86anYGVosiRAZz1ccbrDdeqvCYBbTNBfiMez65zphPJReM-6ateXN8uWINpA";

        public static string City => "New York City";

        public static int TenantId = 1;
    }
}
