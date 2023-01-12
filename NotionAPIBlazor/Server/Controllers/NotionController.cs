using Microsoft.AspNetCore.Mvc;
using NotionAPI.Server.Service;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Databases;

namespace NotionAPI.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class NotionController : ControllerBase
    {
        private readonly string _apiUri = "https://notion.api.com/v1";
        private readonly NotionService notionService;

        public NotionController(NotionService notionService) {
            this.notionService = notionService;
        }

        [HttpPost]
        public async Task<ActionResult<string>> Post()
        {
            return Ok("");
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreateDatabase()
        {
            return Ok("");
        }

        [HttpGet]
        public async Task<string> ListAllUsers()
        {
            return "HIHIHI";
        }

        [HttpPost]
        public async Task<object> QueryDatabase(Dictionary<string, object> data)
        {
            string DatabaseID = (string) data["DatabaseID"];
            QueryBodyParams Data = (QueryBodyParams) data["Data"];

            return await notionService.QueryDatabase(DatabaseID, Data);
        }
    }
}
