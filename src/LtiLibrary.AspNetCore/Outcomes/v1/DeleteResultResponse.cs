﻿using Microsoft.AspNetCore.Http;

namespace LtiLibrary.AspNetCore.Outcomes.v1
{
    /// <summary>
    /// Represents the response to the delete request.
    /// </summary>
    public class DeleteResultResponse
    {
        /// <summary>
        /// Initialize a new instance of the class.
        /// </summary>
        public DeleteResultResponse()
        {
            StatusCode = StatusCodes.Status200OK;
        }

        /// <summary>
        /// The HTTP StatusCode representing the result of the action (OK, NotFound, Unauthorized)
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Optional description of the status. This will be included in the XML response.
        /// </summary>
        public string StatusDescription { get; set; }
    }
}
