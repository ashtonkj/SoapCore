using System;
using System.Reflection;
using System.Xml.Serialization;

namespace SoapCore.Meta
{
	public class TypeToBuild
	{
		public TypeToBuild(Type type)
		{
			Type = type;
			TypeName = type.GetSerializedTypeName();
			ChildElementName = null;
			IsAnonumous = type.GetCustomAttribute<XmlTypeAttribute>()?.AnonymousType == true;
			IncludeInheritedProperties = true;
		}

		public TypeToBuild(Type type, bool includeInheritedProperties) : this(type)
		{
			IncludeInheritedProperties = includeInheritedProperties;
		}

		public bool IsAnonumous { get; }
		public bool IncludeInheritedProperties { get;  }
		public Type Type { get; }
		public string TypeName { get; set; }
		public string ChildElementName { get; set; }
	}
}
