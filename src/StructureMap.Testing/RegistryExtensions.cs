using System;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace StructureMap.Testing
{
    public static class RegistryExtensions
    {
        public static PluginGraph Build(this Registry registry)
        {
            var builder = new PluginGraphBuilder();
            builder.Add(registry);

            return builder.Build();
        }

        [Obsolete("Get rid of this, just use PluginGraph.Families[]")]
        public static PluginFamily FindFamily(this PluginGraph graph, Type pluginType)
        {
            return graph.Families[pluginType];
        }
    }
}