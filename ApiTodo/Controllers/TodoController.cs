using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/todo")]
public class ItemController : ControllerBase
{
private readonly TodoContext _context;
public ItemController(TodoContext context)
{
_context = context;
}


// GET: api/item
[HttpGet]
public async Task<ActionResult<IEnumerable<Todo>>> GetItems()
{
// Get items
var items = _context.Todos;
return await items.ToListAsync();
}

// GET: api/todo/2
[HttpGet("{id}")]
public async Task<ActionResult<Todo>> GetItem(int id)
{
// Find a specific item
// SingleAsync() throws an exception if no item is found (which is possible, depending on id)
// SingleOrDefaultAsync() is a safer choice here
var item = await _context.Todos.SingleOrDefaultAsync(t => t.Id == id);


if (item == null)
return NotFound();


return item;
}

}
