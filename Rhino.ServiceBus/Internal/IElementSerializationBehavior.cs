using System;
using System.Xml.Linq;

namespace Rhino.ServiceBus.Internal
{
	public interface IElementSerializationBehavior
	{
	    bool ShouldApplyOnSerialization(Type type, XElement element);
	    bool ShouldApplyOnDeserialization(Type type, XElement element);
		XElement ApplyElementBehavior(XElement element);
		XElement RemoveElementBehavior(XElement element);
	}
}
