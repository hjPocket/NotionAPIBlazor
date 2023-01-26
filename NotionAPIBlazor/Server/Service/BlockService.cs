using NotionAPIBlazor.Shared.Notion.Api;
using NotionAPIBlazor.Shared.Notion.ApiHelper.Blocks;
using NotionAPIBlazor.Shared.Notion.Models.Blocks;

namespace NotionAPIBlazor.Server.Service
{
    public class BlockService
    {
        private readonly RestApi restAPI;

        public BlockService(NotionAPIService notionAPIService) {
            restAPI = notionAPIService.GetRestApi();
        }

        public async Task<Block> RetrieveBlock(string BlockID)
        {
            return await restAPI.GetAsync<Block>($"/v1/blocks/{BlockID}");
        }

        public async Task<Block> UpdateBlock(string BlockID, UpdateBlockParams Body)
        {
            return await restAPI.PatchAsync<Block>($"/v1/blocks/{BlockID}", Body);
        }

        public async Task<BlockPaginated<Block>> RetrieveBlockChildren(string BlockID, RetrieveBlockChildrenParams? queryParams = null)
        {
            Dictionary<string, string> Params = new();
            if(queryParams != null)
            {
                Params.Add("start_cursor", queryParams.StartCursor);
                Params.Add("page_size", queryParams.PageSize.ToString());
            }

            return await restAPI.GetAsync<BlockPaginated<Block>>($"/v1/blocks/{BlockID}/children", Params);
        }

        public async Task<BlockPaginated<Block>> AppendBlockChildren(string BlockID, AppendBlockChildrenParams Body)
        {
            return await restAPI.PatchAsync<BlockPaginated<Block>>($"/v1/blocks/{BlockID}/children", Body);
        }

        public async Task<Block> DeleteBlock(string BlockID)
        {
            return await restAPI.DeleteAsync<Block>($"/v1/blocks/{BlockID}");
        }
    }
}
