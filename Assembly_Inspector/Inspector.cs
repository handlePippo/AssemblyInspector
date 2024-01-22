using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace AssemblyInspector
{
    internal class Inspector<T> : IInspector<T>
    {
        public Inspector() { }
        public List<MethodInfo> Methods { get; } = new List<MethodInfo>();
        public List<Attribute> Attributes { get; } = new List<Attribute>();

        public List<Attribute> InspectAssemblyAttributes(string path)
        {
            return InspectAssembly(path, true) as List<Attribute>;
        }

        public List<MethodInfo> InspectAssemblyMethods(string path)
        {
            return InspectAssembly(path) as List<MethodInfo>;
        }
        public List<T> InspectAssembly(string path, bool showAttributesInstead = false)
        {
            try
            {
                Assembly assembly = Assembly.LoadFrom(path);
                if (!assembly.GlobalAssemblyCache && assembly.GetName().GetPublicKeyToken() != null)
                {
                    Type[] types = assembly.GetTypes();

                    foreach (Type type in types)
                    {
                        if (showAttributesInstead)
                        {
                            foreach (Attribute a in type.GetCustomAttributes())
                            {
                                if (a is Attribute)
                                {
                                    Attributes.Add(a);
                                }
                            }
                        }
                        else
                        {
                            MethodInfo[] methods = type.GetMethods();
                            Methods.AddRange(methods);
                        }
                    }
                    return showAttributesInstead ? Attributes as List<T> : Methods as List<T>;
                }
                MessageBox.Show("The selected file is not a .NET assembly!", "Close", MessageBoxButtons.OK);
                throw new InvalidOperationException("The selected file is not a .NET assembly!");
            }
            catch (BadImageFormatException ex)
            {
                MessageBox.Show("The selected file is not a valid .NET assembly!", "Close", MessageBoxButtons.OK);
                throw new InvalidOperationException(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Close", MessageBoxButtons.OK);
                throw new Exception(ex.Message + " - " + ex.StackTrace);
            }
        }
    }
}
