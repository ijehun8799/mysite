// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Reflection;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
	private static void Main(string[] args)
	{
		//Console.WriteLine("Hello, World!");

		//ChromeOptions options = new ChromeOptions();
		////options.AddArgument("--user-data-dir=D:\\tmp\\User Data");
		////options.AddArgument("--profile-directory=Profile 1");
		////options.AddArgument("--lang=ko");
		//options.BinaryLocation = @"D:\bin\chrome\GoogleChromePortable64\GoogleChromePortable.exe";
		//String path = @"D:\Tool\chromedriver";    //フォルダを指定
		//IWebDriver driver = new ChromeDriver(path, options);

		//// Webドライバーのインスタンス化
		////IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(path: Assembly.GetEntryAssembly().Location));
		////IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(@"D:\Tool\chromedriver"));

		//// URLに移動します。
		//driver.Navigate().GoToUrl(@"https://www.yahoo.co.jp/");

		//// なにかコンソールに文字を入力したらクロームを閉じる
		////Console.ReadKey();
		////driver.Quit();

		// Webドライバーのインスタンス化
		IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(@"D:\Tool"));

		// URLに移動します。
		driver.Navigate().GoToUrl(@"https://www.yahoo.co.jp/");

		// なにかコンソールに文字を入力したらクロームを閉じる
		Console.ReadKey();
		driver.Quit();
	}
}