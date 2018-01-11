namespace Octokit.GraphQL.Model
{
    using System;
    using System.Linq;

    /// <summary>
    /// Autogenerated input type of MoveProjectColumn
    /// </summary>
    public class MoveProjectColumnInput
    {
        public string ClientMutationId { get; set; }

        public string ColumnId { get; set; }

        public string AfterColumnId { get; set; }
    }
}