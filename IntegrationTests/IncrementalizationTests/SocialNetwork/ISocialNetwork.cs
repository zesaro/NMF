//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Expressions.Tests.SocialNetwork
{
    
    
    /// <summary>
    /// The public interface for SocialNetwork
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(SocialNetwork))]
    [XmlDefaultImplementationTypeAttribute(typeof(SocialNetwork))]
    public interface ISocialNetwork : IModelElement
    {
        
        /// <summary>
        /// The CurrentTime property
        /// </summary>
        [TypeConverterAttribute(typeof(IsoDateTimeConverter))]
        [XmlAttributeAttribute(true)]
        DateTime CurrentTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// The posts property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("posts")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        IOrderedSetExpression<IPost> Posts
        {
            get;
        }
        
        /// <summary>
        /// The users property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("users")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        IOrderedSetExpression<IUser> Users
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the CurrentTime property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CurrentTimeChanging;
        
        /// <summary>
        /// Gets fired when the CurrentTime property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> CurrentTimeChanged;
    }
}

