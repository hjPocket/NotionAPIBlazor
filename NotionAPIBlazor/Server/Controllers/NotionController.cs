using Microsoft.AspNetCore.Mvc;
using NotionAPIBlazor.Server.Service;
using NotionAPIBlazor.Shared.Notion.Api;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Databases;
using NotionAPIBlazor.Shared.Notion.Models;
using NotionAPIBlazor.Shared.Notion.Models.Pages;

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


        [HttpPost]
        public async Task<ActionResult<QueryBodyType>> QueryDatabase(QueryBodyType bodyType) 
        {
            string database_id = bodyType.DatabaseID;
            QueryBodyParams bodyParams = new();
            if(bodyType.Data != null)
            {
                bodyParams = bodyType.Data;
            }

            Pagination<PageStruct> result = await notionService.QueryDatabase(database_id, bodyParams);
            
            if(result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }
    }
}
