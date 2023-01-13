using Microsoft.AspNetCore.Mvc;
using NotionAPIBlazor.Server.Service;
using NotionAPIBlazor.Shared.Notion.Api;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Databases;
using NotionAPIBlazor.Shared.Notion.Models;

namespace NotionAPIBlazor.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NotionController : ControllerBase
    {
        private readonly DatabaseService notionService;

        public NotionController(DatabaseService notionService) 
        {
            this.notionService = notionService;
        }

        [HttpGet("{database_id}")]
        public async Task<Pagination<object>> GetDatabase(string database_id)
        {
            Console.WriteLine(database_id);
            Pagination<object> result = await notionService.QueryDatabase(database_id);
            return result;
        }

        [HttpPost]
        public async Task<ActionResult<QueryBodyType>> QueryDatabase(QueryBodyType bodyType) 
        {
            string database_id = bodyType.DatabaseID;
            QueryBodyParams bodyParams = new();
            if(bodyType.Data != null)
            {
                bodyParams = bodyType.Data;
            }

            Pagination<object> result = await notionService.QueryDatabase(database_id, bodyParams);
            
            if(result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }
    }
}
