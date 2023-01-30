using Microsoft.AspNetCore.Mvc;
using NotionAPIBlazor.Server.Service;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Blocks;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Databases;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Extra;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Pages;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Users;
using NotionAPIBlazor.Shared.Notion.Models;
using NotionAPIBlazor.Shared.Notion.Models.Databases;
using NotionAPIBlazor.Shared.Notion.Models.Extra.Comments;
using NotionAPIBlazor.Shared.Notion.Models.Pages;

namespace NotionAPIBlazor.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NotionController : ControllerBase
    {
        private readonly DatabaseService databaseService;
        private readonly PageService pageService;
        private readonly BlockService blockService;
        private readonly UserService userService;
        private readonly ExtraService extraService;

        public NotionController(
            DatabaseService databaseService, 
            PageService pageService, 
            BlockService blockService, 
            UserService userService,
            ExtraService extraService)
        {
            this.databaseService = databaseService;
            this.pageService = pageService;
            this.blockService = blockService;
            this.userService = userService;
            this.extraService = extraService;
        }


        #region Database API Controller

        [HttpPost]
        public async Task<ActionResult<QueryBodyType>> QueryDatabase(QueryBodyType bodyType)
        {
            string database_id = bodyType.DatabaseID;
            QueryBodyParams bodyParams = new();
            if (bodyType.Data != null)
            {
                bodyParams = bodyType.Data;
            }

            Pagination<Page> result = await databaseService.QueryDatabase(database_id, bodyParams);

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

            if (result != null)
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

            if (result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<RetrieveBodyType>> RetrieveDatabase(RetrieveBodyType bodyType)
        {
            string DatabaseID = bodyType.DatabaseID;

            var result = await databaseService.RetrieveDatabase(DatabaseID);

            if (result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        #endregion

        #region Page API Controller

        [HttpPost]
        public async Task<ActionResult<RetrievePageType>> RetrievePage(RetrievePageType bodyType)
        {
            string PageID = bodyType.PageID;

            var result = await pageService.RetrievePage(PageID, bodyType.Params);

            if (result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<CreatePageType>> CreatePage(CreatePageType bodyType)
        {
            var result = await pageService.CreatePage(bodyType.Data);

            if (result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<UpdatePageType>> UpdatePage(UpdatePageType bodyType)
        {
            var result = await pageService.UpdatePage(bodyType.PageID, bodyType.Data);

            if (result != null)
            {
                bodyType.ReturnValue = result;
            }

            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<RetrievePropertyType>> RetrievePageProperty(RetrievePropertyType bodyType)
        {
            var result = await pageService.RetrievePagePropertyItem(bodyType.PageID, bodyType.PropertyID, bodyType.queryParams);

            if (result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        #endregion

        #region Block API Controller

        [HttpPost]
        public async Task<ActionResult<RetrieveBlockType>> RetrieveBlock(RetrieveBlockType bodyType)
        {
            var result = await blockService.RetrieveBlock(bodyType.BlockID);

            if (result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<UpdateBlockType>> UpdateBlock(UpdateBlockType bodyType)
        {
            var result = await blockService.UpdateBlock(bodyType.BlockID, bodyType.Data);

            if (result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<RetrieveBlockChildrenType>> RetrieveBlockChildren(RetrieveBlockChildrenType bodyType)
        {
            Console.WriteLine("Retrieve");
            var result = await blockService.RetrieveBlockChildren(bodyType.BlockID, bodyType?.Data);
            if (result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<AppendBlockChildrenType>> AppendBlockChildren(AppendBlockChildrenType bodyType)
        {
            var result = await blockService.AppendBlockChildren(bodyType.BlockID, bodyType.Data);

            if (result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<DeleteBlockType>> DeleteBlock(DeleteBlockType bodyType)
        {
            var result = await blockService.DeleteBlock(bodyType.BlockID);

            if (result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        #endregion

        #region User API Controller

        [HttpPost]
        public async Task<ActionResult<ListAllUsersType>> ListAllUsers(ListAllUsersType bodyType)
        {
            //Console.WriteLine("HIHIHIHIHI");
            var result = await userService.ListAllUsers(bodyType.Data);

            if (result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<RetrieveUserType>> RetrieveUser(RetrieveUserType bodyType)
        {
            var result = await userService.RetrieveUser(bodyType.UserID);

            if(result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<object>> RetrieveBotUser(RetrieveBotUserType bodyType)
        {
            var result = await userService.RetrieveBotUser();

            if (result != null)
            {
                bodyType.ReturnData = result;
            }
            return Ok(bodyType);
        }

        #endregion

        #region Extras (Search, Comment)

        [HttpPost]
        public async Task<ActionResult<SearchBodyType>> Search(SearchBodyType bodyType)
        {
            var result = await extraService.Search(bodyType?.Data);

            if(result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<RetrieveCommentType>> RetrieveComment(RetrieveCommentType bodyType)
        {
            var result = await extraService.RetrieveComment(bodyType.Data);
            Console.WriteLine(bodyType.Data.BlockID);

            if(result != null)
            {
                bodyType.RetrunData = result;
            }

            return Ok(bodyType);
        }

        [HttpPost]
        public async Task<ActionResult<CreateCommentType>> CreateComment(CreateCommentType bodyType)
        {
            var result = await extraService.CreateComment(bodyType.Data);

            if(result != null)
            {
                bodyType.ReturnData = result;
            }

            return Ok(bodyType);
        }

        #endregion
    }
}
