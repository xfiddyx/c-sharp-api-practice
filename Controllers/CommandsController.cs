using System.Collections.Generic;
using CommandLineAPI.Data;
using CommandLineAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandLineAPI.Controllers
{
 [Route("api/commands")]
 [ApiController]
 public class CommandsController : ControllerBase
 {
  private readonly ICommandLineRepo _repository;

  public CommandsController(ICommandLineRepo repository)
  {
   _repository = repository;
  }
  // private readonly MockCommandRepo _repository = new MockCommandRepo();
  [HttpGet]
  public ActionResult<IEnumerable<Command>> GetAllCommands()
  {
   var commandItems = _repository.GetAllCommands();

   return Ok(commandItems);
  }
  [HttpGet("{id}")]
  public ActionResult<Command> GetCommandById(int id)
  {
   var commandItemById = _repository.GetCommandById(id);

   return Ok(commandItemById);
  }
 }
}