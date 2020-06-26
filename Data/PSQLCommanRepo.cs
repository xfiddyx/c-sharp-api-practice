using System.Collections.Generic;
using System.Linq;
using CommandLineAPI.Models;

namespace CommandLineAPI.Data
{
 public class PsqlCommandRepo : ICommandLineRepo
 {
  private readonly CommandLineAPIContext _context;
  public PsqlCommandRepo(CommandLineAPIContext context)
  {
   _context = context;
  }
  public IEnumerable<Command> GetAllCommands()
  {
   return _context.Commands.ToList();
  }

  public Command GetCommandById(int id)
  {
   return _context.Commands.FirstOrDefault(p => p.Id == id);
  }
 }
}