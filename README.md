# Numeric Sequence Calculator
This application prints following numeric sequences for the given number.
- Numbers up to given number
- Odd numbers up to given number
- Even numbers up to given number
- Encoded numbers up to given number
  - If divided by 3, print 'C'
  - If divided by 5, print 'E'
  - If divided by both, print 'Z'
- Fibonacci sequence up to given number

## How to run the application?

### Prerequisites
- Visual Studio 2015
- .Net Framework 4.5.2
- Asp.Net MVC
- Google Chrome Browser

### Visual Studio Projects
- NumericSequenceCalculator
  - This is a Asp.Net MVC application runs on .Net Framework 4.5.2
- NumericSequenceCalculator.Tests
  - This is a Visual Studio Test project .Net Framework 4.5.2
  
### Steps to execute
1. Download Visual Studio Community/enterprise/professional edition.
2. Open the solution file 'NumericSequenceCalculator'.
3. Right click on 'NumericSequenceCalculator' project and select 'Set as StartUp Project'.
4. Right click on 'NumericSequenceCalculator' project and select 'Properties'. In the properties window, select 'Web' tab. Under the debugger section, uncheck 'Enable Edit and Continue', if it is not already unchecked.
5. Build and run NumericSequenceCalculator solution and wait for the Visual Studio to open the web browser. When the browser has rendered the application, perfrom manual testing.
6. After the manual testing, go to Visual Studio and stop debugging. Application would keep running as it is hosted by IIS Express.
7. Copy NumericSequenceCalculator.Tests/ChromeWebDrive/chromedriver.exe file to NumericSequenceCalculator.Tests\bin\Debug folder.
8. In Visual Studio, Go to menu, click on Test > Windows > Test Explorer. This will open up Test Explorer. Click on 'Run All' link to execute all the test cases.

### Additional Information
- Technologies used are Asp.Net MVC, .Net Framework 4.5, C#.
- Buit using Visual Studio Community Edition.
- Visual Studio Unit testing framework is used to test Numeric Sequence service.
- Selenium.WebDriver.2.53.1 is used for UI driven functional testing.

**NOTE: Only chrome browser is used for test automation. It is recommened to use the same browser.**
