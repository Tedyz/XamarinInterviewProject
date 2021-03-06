﻿using GenesisAuto.Core.Models;
using GenesisAuto.Core.Models.Api;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenesisAuto.Core.Services
{
    [Headers("User-Agent: :request:")]
    public interface IGitHubApi
    {
        [Get("/search/repositories")]
        Task<ApiResponse<ResponseGitHubRepositories>> GetRepositories(string q, string type, string sort, int page);

        [Get("/repos/{username}/{repo}/pulls")]
        Task<List<PullRequest>> GetPullRequests([AliasAs("username")] string username, [AliasAs("repo")] string repo, int page, string state = "open");
    }

}
