using System;

namespace MShared
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class IndexAttribute : Attribute
    {
        public bool IsUnique { get; protected set; }

        public string[] PropertyNames { get; set; }

        public IndexAttribute(params string[] propertyNames) : this(false, propertyNames)
        {
        }

        public IndexAttribute(bool isUnique, params string[] propertyNames)
        {
            IsUnique = isUnique;
            PropertyNames = propertyNames;
        }
    }
}
