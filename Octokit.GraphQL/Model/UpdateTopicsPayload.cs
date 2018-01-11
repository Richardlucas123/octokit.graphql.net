namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of UpdateTopics
    /// </summary>
    public class UpdateTopicsPayload : QueryEntity
    {
        public UpdateTopicsPayload(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// Names of the provided topics that are not valid.
        /// </summary>
        public IQueryable<string> InvalidTopicNames => this.CreateProperty(x => x.InvalidTopicNames);

        /// <summary>
        /// The updated repository.
        /// </summary>
        public Repository Repository => this.CreateProperty(x => x.Repository, Octokit.GraphQL.Model.Repository.Create);

        internal static UpdateTopicsPayload Create(IQueryProvider provider, Expression expression)
        {
            return new UpdateTopicsPayload(provider, expression);
        }
    }
}