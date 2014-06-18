using System;

namespace Sycade.IeAutomation.Base
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TagAttribute : Attribute
    {
        public string Name { get; protected set; }
        public string InputType { get; protected set; }

        public TagAttribute(string name, string inputType = null)
        {
            Name = name;
            InputType = inputType;
        }
    }
}
