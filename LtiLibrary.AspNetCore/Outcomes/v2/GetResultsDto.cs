﻿using LtiLibrary.NetCore.Outcomes.v2;
using Microsoft.AspNetCore.Http;

namespace LtiLibrary.AspNetCore.Outcomes.v2
{
    public class GetResultsDto
    {
        public GetResultsDto(string contextId, string lineItemId, int? limit, int page)
        {
            ContextId = contextId;
            Limit = limit;
            LineItemId = lineItemId;
            Page = page;
            StatusCode = StatusCodes.Status200OK;
        }

        public string ContextId { get; set; }
        public string LineItemId { get; set; }
        public int? Limit { get; set; }
        public ResultContainerPage ResultContainerPage { get; set; }
        public int Page { get; set; }
        public int StatusCode { get; set; }
    }
}