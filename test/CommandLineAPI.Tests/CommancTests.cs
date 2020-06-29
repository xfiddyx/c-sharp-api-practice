using System;
using Xunit;
using CommandLineAPI.Models;

namespace CommandLineAPI.Tests
{

 public class CommandTests
 {

  [Fact]
  public void CanChangeHowTo()
  {
   var testCommand = new Command
   {
    HowTo = "Do something",
    Platform = "xUnit",
    Line = "dotnet test"
   };

   testCommand.HowTo = "Execute unit tests";

   Assert.Equal("Execute unit tests", testCommand.HowTo);
  }

 }
}