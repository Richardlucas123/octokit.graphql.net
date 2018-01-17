namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Represents triggered deployment instance.
    /// </summary>
    public class Deployment : QueryEntity
    {
        public Deployment(IQueryProvider provider, Expression expression) : base(provider, expression)
        {
        }

        /// <summary>
        /// Identifies the commit sha of the deployment.
        /// </summary>
        public Commit Commit => this.CreateProperty(x => x.Commit, Octokit.GraphQL.Model.Commit.Create);

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public DateTimeOffset? CreatedAt { get; }

        /// <summary>
        /// Identifies the actor who triggered the deployment.
        /// </summary>
        public IActor Creator => this.CreateProperty(x => x.Creator, Octokit.GraphQL.Model.Internal.StubIActor.Create);

        /// <summary>
        /// Identifies the primary key from the database.
        /// </summary>
        [Obsolete(@"Exposed database IDs will eventually be removed in favor of global Relay IDs.")]
        public int? DatabaseId { get; }

        /// <summary>
        /// The environment to which this deployment was made.
        /// </summary>
        public string Environment { get; }

        public string Id { get; }

        /// <summary>
        /// The latest status of this deployment.
        /// </summary>
        public DeploymentStatus LatestStatus => this.CreateProperty(x => x.LatestStatus, Octokit.GraphQL.Model.DeploymentStatus.Create);

        /// <summary>
        /// Extra information that a deployment system might need.
        /// </summary>
        public string Payload { get; }

        /// <summary>
        /// Identifies the repository associated with the deployment.
        /// </summary>
        public Repository Repository => this.CreateProperty(x => x.Repository, Octokit.GraphQL.Model.Repository.Create);

        /// <summary>
        /// The current state of the deployment.
        /// </summary>
        public DeploymentState? State { get; }

        /// <summary>
        /// A list of statuses associated with the deployment.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified global ID.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified global ID.</param>
        public DeploymentStatusConnection Statuses(int? first = null, string after = null, int? last = null, string before = null) => this.CreateMethodCall(x => x.Statuses(first, after, last, before), Octokit.GraphQL.Model.DeploymentStatusConnection.Create);

        internal static Deployment Create(IQueryProvider provider, Expression expression)
        {
            return new Deployment(provider, expression);
        }
    }
}