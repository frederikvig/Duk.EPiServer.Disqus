﻿using Duk.EPiServer.Disqus.Models;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace Duk.EPiServer.Disqus.UI.Models
{
    /// <summary>
    /// Configures service locator with default implementations
    /// </summary>
    [InitializableModule]
    [ModuleDependency(typeof(InitializationModule))]
    public class UiInitializationModule : IConfigurableModule
    {
        /// <summary>
        /// Configures the service container.
        /// </summary>
        /// <param name="context">The context.</param>
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.StructureMap().Configure(ce => ce.For<IRenderingEditModeExtension>().Use<RenderingEditModeExtension>());
        }

        /// <summary>
        /// Called when initializing.
        /// </summary>
        /// <param name="context">The context.</param>
        public void Initialize(InitializationEngine context)
        {
        }

        /// <summary>
        /// Called when uninitializing.
        /// </summary>
        /// <param name="context">The context.</param>
        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}
