using System;

namespace Sycade.IeAutomation.Base
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TagAttribute : Attribute
    {
        public string TagName { get; protected set; }
        public string InputType { get; protected set; }

        public TagAttribute(string tagName, string inputType = null)
        {
            TagName = tagName;
            InputType = inputType;
        }
    }
}
