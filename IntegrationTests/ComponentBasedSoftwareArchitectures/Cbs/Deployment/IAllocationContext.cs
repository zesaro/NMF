//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.ComponentBasedSystems;
using NMFExamples.ComponentBasedSystems.Assembly;
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
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.ComponentBasedSystems.Deployment
{
    
    
    /// <summary>
    /// The public interface for AllocationContext
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AllocationContext))]
    [XmlDefaultImplementationTypeAttribute(typeof(AllocationContext))]
    public interface IAllocationContext : IModelElement
    {
        
        /// <summary>
        /// The Assembly property
        /// </summary>
        IAssemblyContext Assembly
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Container property
        /// </summary>
        IContainer_MM06 Container
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Assembly property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> AssemblyChanging;
        
        /// <summary>
        /// Gets fired when the Assembly property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> AssemblyChanged;
        
        /// <summary>
        /// Gets fired before the Container property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ContainerChanging;
        
        /// <summary>
        /// Gets fired when the Container property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ContainerChanged;
    }
}

