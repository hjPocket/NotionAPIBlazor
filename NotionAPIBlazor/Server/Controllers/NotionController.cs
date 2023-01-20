using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NotionAPIBlazor.Server.Service;
using NotionAPIBlazor.Shared.Notion.Api;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Databases;
using NotionAPIBlazor.Shared.Notion.Models;
using NotionAPIBlazor.Shared.Notion.Models.Databases;
using NotionAPIBlazor.Shared.Notion.Models.Pages;

namespace NotionAPIBlazor.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NotionController : ControllerBase
    {
        private readonly DatabaseService databaseService;

        public NotionController(DatabaseService databaseService) 
        {
            this.databaseService = databaseService;
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

            Console.WriteLine("======");
            Pagination<Page> result = await databaseService.QueryDatabase(database_id, bodyParams);

            Console.WriteLine("======");
            if (result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<CreateBodyType>> CreateDatabase(CreateBodyType bodyType)
        {
            CreateBodyParams Body = bodyType.Data;

            Database result = await databaseService.CreateDatabase(Body);

            if(result != null)
            {
                bodyType.ReturnData = result;
            }
            
            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<UpdateBodyType>> UpdateDatabase(UpdateBodyType bodyType)
        {
            string DatabaseID = bodyType.DatabaseID;
            UpdateBodyParams BodyParams = bodyType.Data;

            var result = await databaseService.UpdateDatabase(DatabaseID, BodyParams);

            if(result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<RetrieveBodyType>> RetrieveDatabase(RetrieveBodyType bodyType)
        {
            string DatabaseID = bodyType.DatabaseID;

            await databaseService.RetrieveDatabase(DatabaseID);

            var result = await databaseService.RetrieveDatabase(DatabaseID);

            if (result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }
    }
}
