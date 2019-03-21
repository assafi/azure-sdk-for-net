// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ArtifactsOperations.
    /// </summary>
    public static partial class ArtifactsOperationsExtensions
    {
            /// <summary>
            /// Create or update blueprint artifact.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='blueprintName'>
            /// Name of the blueprint definition.
            /// </param>
            /// <param name='artifactName'>
            /// Name of the blueprint artifact.
            /// </param>
            /// <param name='artifact'>
            /// Blueprint artifact to create or update.
            /// </param>
            public static Artifact CreateOrUpdate(this IArtifactsOperations operations, string scope, string blueprintName, string artifactName, Artifact artifact)
            {
                return operations.CreateOrUpdateAsync(scope, blueprintName, artifactName, artifact).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update blueprint artifact.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='blueprintName'>
            /// Name of the blueprint definition.
            /// </param>
            /// <param name='artifactName'>
            /// Name of the blueprint artifact.
            /// </param>
            /// <param name='artifact'>
            /// Blueprint artifact to create or update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Artifact> CreateOrUpdateAsync(this IArtifactsOperations operations, string scope, string blueprintName, string artifactName, Artifact artifact, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(scope, blueprintName, artifactName, artifact, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a blueprint artifact.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='blueprintName'>
            /// Name of the blueprint definition.
            /// </param>
            /// <param name='artifactName'>
            /// Name of the blueprint artifact.
            /// </param>
            public static Artifact Get(this IArtifactsOperations operations, string scope, string blueprintName, string artifactName)
            {
                return operations.GetAsync(scope, blueprintName, artifactName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a blueprint artifact.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='blueprintName'>
            /// Name of the blueprint definition.
            /// </param>
            /// <param name='artifactName'>
            /// Name of the blueprint artifact.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Artifact> GetAsync(this IArtifactsOperations operations, string scope, string blueprintName, string artifactName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, blueprintName, artifactName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a blueprint artifact.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='blueprintName'>
            /// Name of the blueprint definition.
            /// </param>
            /// <param name='artifactName'>
            /// Name of the blueprint artifact.
            /// </param>
            public static Artifact Delete(this IArtifactsOperations operations, string scope, string blueprintName, string artifactName)
            {
                return operations.DeleteAsync(scope, blueprintName, artifactName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a blueprint artifact.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='blueprintName'>
            /// Name of the blueprint definition.
            /// </param>
            /// <param name='artifactName'>
            /// Name of the blueprint artifact.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Artifact> DeleteAsync(this IArtifactsOperations operations, string scope, string blueprintName, string artifactName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(scope, blueprintName, artifactName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List artifacts for a given blueprint definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='blueprintName'>
            /// Name of the blueprint definition.
            /// </param>
            public static IPage<Artifact> List(this IArtifactsOperations operations, string scope, string blueprintName)
            {
                return operations.ListAsync(scope, blueprintName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List artifacts for a given blueprint definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the resource. Valid scopes are: management group (format:
            /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
            /// subscription (format: '/subscriptions/{subscriptionId}').
            /// </param>
            /// <param name='blueprintName'>
            /// Name of the blueprint definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Artifact>> ListAsync(this IArtifactsOperations operations, string scope, string blueprintName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, blueprintName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List artifacts for a given blueprint definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Artifact> ListNext(this IArtifactsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List artifacts for a given blueprint definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Artifact>> ListNextAsync(this IArtifactsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}