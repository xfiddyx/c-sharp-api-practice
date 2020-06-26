using System.Collections.Generic;
using CommandLineAPI.Models;

namespace CommandLineAPI.Data
{
 public interface ICommandLineRepo
 {
  IEnumerable<Command> GetAllCommands();
  Command GetCommandById(int id);
 }
}
