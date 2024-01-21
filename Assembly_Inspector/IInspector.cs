using System;
using System.Collections.Generic;
using System.Reflection;

namespace AssemblyInspector
{
    internal interface IInspector<T>
    {
        List<T> InspectAssembly(string path, bool showAttributesInstead);
        List<MethodInfo> InspectAssemblyMethods(string path);
        List<Attribute> InspectAssemblyAttributes(string path);
        List<MethodInfo> Methods { get; }
        List<Attribute> Attributes { get; }
    }
}
