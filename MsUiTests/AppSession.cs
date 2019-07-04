using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;

public class AppSession
{
    // Note: append /wd/hub to the URL if you're directing the test at Appium
    private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
    private const string AppPath = @"D:\WpfDemo\WpfDemo\bin\Debug\WpfDemo.exe";//"Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

    protected static WindowsDriver<WindowsElement> session;

    public static void Setup(TestContext context)
    {
        // Launch Calculator application if it is not yet launched
        if (session == null)
        {
            // Create a new session to bring up an instance of the Calculator application
            // Note: Multiple calculator windows (instances) share the same process Id
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", AppPath);
            appCapabilities.SetCapability("deviceName", "WindowsPC");
            session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
            Assert.IsNotNull(session);

            // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
            session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);
        }
    }

    public static void TearDown()
    {
        // Close the application and delete the session
        if (session != null)
        {
            session.Quit();
            session = null;
        }
    }
}