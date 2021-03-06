namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Ordering options for team repository connections
    /// </summary>
    public class TeamRepositoryOrder
    {
        public TeamRepositoryOrderField Field { get; set; }

        public OrderDirection Direction { get; set; }
    }
}