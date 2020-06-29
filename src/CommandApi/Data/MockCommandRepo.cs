using System.Collections.Generic;
using CommandLineAPI.Models;

namespace CommandLineAPI.Data
{
 public class MockCommandRepo : ICommandLineRepo
 {
  public IEnumerable<Command> GetAllCommands()
  {
   var command = new List<Command>
   {
new Command{Id = 0, HowTo = "How to boil an egg", Line = "Boil Water", Platform = "Kettle and Pan"},
new Command{Id = 1, HowTo = "How to fry an egg", Line = "Heat a Pan", Platform = "Hob and Pan"},
new Command{Id = 2, HowTo = "How to make scrambled egg", Line = "Whisk an egg", Platform = "Hob, Whisk and Pan"}
   };

   return command;
  }

  public Command GetCommandById(int id)
  {
   return new Command { Id = 0, HowTo = "How to boil an egg", Line = "Boil Water", Platform = "Kettle and Pan" };
  }

 }
}