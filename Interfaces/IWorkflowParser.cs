﻿using OptimaJet.Workflow.Core.Model;

namespace OptimaJet.Workflow.Core.Parser
{

    /// <summary>
    /// Interface of a workflow parser, which parses not parsed process scheme <see cref="SchemeDefinition{T}"/> to the object model of a scheme of a process <see cref="ProcessDefinition"/>
    /// </summary>
    /// <typeparam name="TSchemeMedium">Type of not parsed scheme</typeparam>
    public interface IWorkflowParser<TSchemeMedium> where TSchemeMedium : class
    {
        /// <summary>
        /// Returns object model of the scheme of a process
        /// </summary>
        /// <param name="schemeMedium">Not parsed scheme</param>
        /// <returns>ProcessDefinition object</returns>
        ProcessDefinition Parse(TSchemeMedium schemeMedium);
        /// <summary>
        /// Returns object model of the scheme of a process
        /// </summary>
        /// <param name="scheme">String representation of not parsed scheme</param>
        /// <returns>ProcessDefinition object</returns>
        ProcessDefinition Parse(string scheme);

        /// <summary>
        /// Serializes object model of the scheme to not parsed scheme
        /// </summary>
        /// <param name="processDefinition">ProcessDefinition object</param>
        /// <returns>Not parsed scheme</returns>
        TSchemeMedium SerializeToSchemeMedium(ProcessDefinition processDefinition);

        /// <summary>
        /// Serializes object model of the scheme to string
        /// </summary>
        /// <param name="processDefinition">ProcessDefinition object</param>
        /// <returns>String representation of not parsed scheme</returns>
        string SerializeToString(ProcessDefinition processDefinition);
    }
}
