using CommandLineAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandLineAPI.Data
{


 public class CommandLineAPIContext : DbContext
 {
  public CommandLineAPIContext(DbContextOptions<CommandLineAPIContext> options) : base(options)
  {
  }
  public DbSet<Command> Commands { get; set; }
  //The Db is used to set the database and it is using the Command models i.e. the id, howto, line and platform and is saying setthe database using the ints and strings set in the commandline file in models.


 }
}