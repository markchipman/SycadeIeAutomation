using System;

namespace Sycade.IeAutomation.Base
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TagNameAttribute : Attribute
    {
        public string TagName { get; protected set; }

        public TagNameAttribute(string tagName)
        {
            TagName = tagName;
        }
    }
}
