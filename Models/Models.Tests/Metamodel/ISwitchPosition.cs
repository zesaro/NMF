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
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Tests.Railway
{
    
    
    /// <summary>
    /// The public interface for SwitchPosition
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(SwitchPosition))]
    [XmlDefaultImplementationTypeAttribute(typeof(SwitchPosition))]
    public interface ISwitchPosition : IModelElement, IRailwayElement
    {
        
        /// <summary>
        /// The position property
        /// </summary>
        Position Position
        {
            get;
            set;
        }
        
        /// <summary>
        /// The switch property
        /// </summary>
        ISwitch Switch
        {
            get;
            set;
        }
        
        /// <summary>
        /// The route property
        /// </summary>
        IRoute Route
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Position property changes its value
        /// </summary>
        event EventHandler PositionChanging;
        
        /// <summary>
        /// Gets fired when the Position property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> PositionChanged;
        
        /// <summary>
        /// Gets fired before the Switch property changes its value
        /// </summary>
        event EventHandler SwitchChanging;
        
        /// <summary>
        /// Gets fired when the Switch property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> SwitchChanged;
        
        /// <summary>
        /// Gets fired when the Route property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> RouteChanged;
    }
}

