namespace Octokit.GraphQL.Model
{
    using System;
    using System.Linq;

    /// <summary>
    /// Autogenerated input type of UpdatePullRequestReviewComment
    /// </summary>
    public class UpdatePullRequestReviewCommentInput
    {
        public string ClientMutationId { get; set; }

        public string PullRequestReviewCommentId { get; set; }

        public string Body { get; set; }
    }
}