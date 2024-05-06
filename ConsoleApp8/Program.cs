using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Threading;
using OpenQA.Selenium.Interactions;

class GoogleCloudAutomation
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("https://cloud.google.com/");

        IWebElement searchIcon = driver.FindElement(By.ClassName("YSM5S"));
        searchIcon.Click();

        IWebElement searchField = driver.FindElement(By.ClassName("qdOxv-fmcmS-wGMbrd"));
        searchField.SendKeys("Google Cloud Platform Pricing Calculator");

        IWebElement searchButton = driver.FindElement(By.ClassName("PETVs-OWXEXe-UbuQg"));
        searchButton.Click();

        Thread.Sleep(3000);
        IWebElement searchResult = driver.FindElement(By.ClassName("K5hUy"));
        searchResult.Click();

        IWebElement addToEstimate = driver.FindElement(By.ClassName("VfPpkd-dgl2Hf-ppHlrf-sM5MNb"));
        addToEstimate.Click();

        IWebElement computerEngine = driver.FindElement(By.ClassName("aHij0b-aGsRMb"));
        computerEngine.Click();

        Thread.Sleep(5000);
        IWebElement instanceField = driver.FindElement(By.Id("c11"));
        instanceField.Clear();
        instanceField.SendKeys("4");

        var js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("window.scrollBy(0,400)", "");

        IWebElement softwareDrop = driver.FindElement(By.CssSelector("div.O1htCb-H9tDt.PPUDSe.t8xIwc"));
        softwareDrop.Click();

        IWebElement softwareDropOption = driver.FindElement(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[7]/div/div[1]/div/div/div/div[2]/ul/li[1]"));
        softwareDropOption.Click();

        IWebElement provisioningButton = driver.FindElement(By.XPath("//label[text()='Regular']"));
        provisioningButton.Click();

        IWebElement machineDrop = driver.FindElement(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[1]/div"));
        machineDrop.Click();

        IWebElement machineDropOption = driver.FindElement(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[1]/div/div/div/div[2]/ul/li[1]"));
        machineDropOption.Click();

        IWebElement serieseDrop = driver.FindElement(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/div"));
        serieseDrop.Click();

        IWebElement serieseDropOption = driver.FindElement(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[2]/div/div/div/div[2]/ul/li[1]"));
        serieseDropOption.Click();

        IWebElement machineTypeDrop = driver.FindElement(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[1]/div"));
        machineTypeDrop.Click();

        IWebElement machineTypeDropOption = driver.FindElement(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[2]/ul/li[7]"));
        machineTypeDropOption.Click();

        IWebElement addGPU = driver.FindElement(By.XPath("//*[@id=\"ucj-1\"]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[21]/div/div/div[1]/div/div/span/div/button/div/span[1]"));
        addGPU.Click();

        Thread.Sleep(5000);

        IWebElement gpuModelDrop = driver.FindElement(By.XPath("//*[@id=\"ucj-1\"]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[1]/div"));
        gpuModelDrop.Click();

        IWebElement gpuModelDropOption = driver.FindElement(By.XPath("//*[@id=\"ucj-1\"]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[2]/ul/li[3]"));
        gpuModelDropOption.Click();
        IWebElement gpuNumberDrop = driver.FindElement(By.XPath("//*[@id=\"ucj-1\"]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[24]/div/div[1]/div/div/div/div[1]/div"));
        gpuNumberDrop.Click();

        IWebElement gpuNumberDropOption = driver.FindElement(By.XPath("//*[@id=\"ucj-1\"]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[24]/div/div[1]/div/div/div/div[2]/ul/li[1]"));
        gpuNumberDropOption.Click();

        IWebElement ssdDrop = driver.FindElement(By.XPath("//*[@id=\"ucj-1\"]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[1]/div"));
        ssdDrop.Click();

        IWebElement ssdDropOption = driver.FindElement(By.XPath("//*[@id=\"ucj-1\"]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[2]/ul/li[3]"));
        ssdDropOption.Click();

        IWebElement regionDrop = driver.FindElement(By.XPath("//*[@id=\"ucj-1\"]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[29]/div/div[1]/div/div/div/div[1]/div"));
        regionDrop.Click();

        IWebElement regionDropOption = driver.FindElement(By.XPath("//*[@id=\"ucj-1\"]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[29]/div/div[1]/div/div/div/div[2]/ul/li[4]"));
        regionDropOption.Click();

        IWebElement commitedUsageButton = driver.FindElement(By.XPath("//*[@id=\"ucj-1\"]/div/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[31]/div/div/div[2]/div/div/div[2]"));
        commitedUsageButton.Click();

        Thread.Sleep(5000);

        IWebElement shareButton = driver.FindElement(By.XPath("//*[@id=\"ow4\"]/div/div/div/div/div/div/div[2]/div[1]/div/div[4]/div[2]/div[1]/span[1]/div[1]/a"));
        shareButton.Click();

        Thread.Sleep(5000);
        var windowHandles = driver.WindowHandles;
        driver.SwitchTo().Window(windowHandles[1]);

        IWebElement typeTextElement = driver.FindElement(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz[1]/div/div/div/div/div[2]/div[2]/div[1]/div[2]/div[3]/span[2]/span[1]/span[2]"));
        var typeText = typeTextElement.Text;
        Console.WriteLine(typeText == "n1-standard-8, vCPUs: 8, RAM: 30 GB" ? "Test1 - passed" : "Test1 - failed");

        IWebElement modelTextElement = driver.FindElement(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz[1]/div/div/div/div/div[2]/div[2]/div[1]/div[2]/div[4]/span[2]/span[1]/span[2]"));
        var modelText = modelTextElement.Text;
        Console.WriteLine(modelText == "NVIDIA Tesla V100" ? "Test2 - passed" : "Test2 - failed");

        IWebElement gpuNumberTextElement = driver.FindElement(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz[1]/div/div/div/div/div[2]/div[2]/div[1]/div[2]/div[4]/span[3]/span[1]/span[2]"));
        var gpuNumberText = gpuNumberTextElement.Text;
        Console.WriteLine(gpuNumberText == "1" ? "Test3 - passed" : "Test3 - failed");

        IWebElement ssdTextElement = driver.FindElement(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz[1]/div/div/div/div/div[2]/div[2]/div[1]/div[2]/div[5]/span/span[1]/span[2]"));
        var ssdText = ssdTextElement.Text;
        Console.WriteLine(ssdText == "2x375 GB" ? "Test4 - passed" : "Test4 - failed");

        IWebElement instanceNumberTextElement = driver.FindElement(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz[1]/div/div/div/div/div[2]/div[2]/div[1]/div[2]/div[7]/span/span[1]/span[2]"));
        var instanceNumberText = instanceNumberTextElement.Text;
        Console.WriteLine(instanceNumberText == "4" ? "Test5 - passed" : "Test5 - failed");

        IWebElement softwareTextElement = driver.FindElement(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz[1]/div/div/div/div/div[2]/div[2]/div[1]/div[2]/div[8]/span/span[1]/span[2]"));
        var softwareText = softwareTextElement.Text;
        Console.WriteLine(softwareText == "Free: Debian, CentOS, CoreOS, Ubuntu or BYOL (Bring Your Own License)" ? "Test6 - passed" : "Test6 - failed");
        
        IWebElement gpuCheckTextElement = driver.FindElement(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz[1]/div/div/div/div/div[2]/div[2]/div[1]/div[2]/div[13]/span/span[1]/span[2]"));
        var gpuCheckText = gpuCheckTextElement.Text;
        Console.WriteLine(gpuCheckText == "true" ? "Test7 - passed" : "Test7 - failed");

        IWebElement regionTextElement = driver.FindElement(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz[1]/div/div/div/div/div[2]/div[2]/div[1]/div[2]/div[15]/span/span[1]/span[2]"));
        var regionText = regionTextElement.Text;
        Console.WriteLine(regionText == "Netherlands (europe-west4)" ? "Test8 - passed" : "Test8 - failed");

        Thread.Sleep(15000);
        driver.Quit();
    }
}