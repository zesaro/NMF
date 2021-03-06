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

namespace NMF.Models.Meta
{
    
    
    /// <summary>
    /// The default implementation of the ModelElement class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/nmeta/")]
    [XmlNamespacePrefixAttribute("nmeta")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//ModelElement")]
    public abstract partial class ModelElement : NMF.Models.ModelElement, NMF.Models.IModelElement, NMF.Models.IModelElement
    {
        
        /// <summary>
        /// The backing field for the AbsoluteUri property
        /// </summary>
        private Uri _absoluteUri;
        
        private static Lazy<ITypedElement> _absoluteUriAttribute = new Lazy<ITypedElement>(RetrieveAbsoluteUriAttribute);
        
        /// <summary>
        /// The backing field for the RelativeUri property
        /// </summary>
        private Uri _relativeUri;
        
        private static Lazy<ITypedElement> _relativeUriAttribute = new Lazy<ITypedElement>(RetrieveRelativeUriAttribute);
        
        private static Lazy<ITypedElement> _extensionsReference = new Lazy<ITypedElement>(RetrieveExtensionsReference);
        
        /// <summary>
        /// The backing field for the Extensions property
        /// </summary>
        private ModelElementExtensionsCollection _extensions;
        
        private static Lazy<ITypedElement> _parentReference = new Lazy<ITypedElement>(RetrieveParentReference);
        
        /// <summary>
        /// The backing field for the Parent property
        /// </summary>
        private NMF.Models.IModelElement _parent;
        
        private static IClass _classInstance;
        
        public ModelElement()
        {
            this._extensions = new ModelElementExtensionsCollection(this);
            this._extensions.CollectionChanging += this.ExtensionsCollectionChanging;
            this._extensions.CollectionChanged += this.ExtensionsCollectionChanged;
        }
        
        /// <summary>
        /// The AbsoluteUri property
        /// </summary>
        [CategoryAttribute("ModelElement")]
        [XmlAttributeAttribute(true)]
        public Uri AbsoluteUri
        {
            get
            {
                return this._absoluteUri;
            }
            set
            {
                if ((this._absoluteUri != value))
                {
                    Uri old = this._absoluteUri;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAbsoluteUriChanging(e);
                    this.OnPropertyChanging("AbsoluteUri", e, _absoluteUriAttribute);
                    this._absoluteUri = value;
                    this.OnAbsoluteUriChanged(e);
                    this.OnPropertyChanged("AbsoluteUri", e, _absoluteUriAttribute);
                }
            }
        }
        
        /// <summary>
        /// The RelativeUri property
        /// </summary>
        [CategoryAttribute("ModelElement")]
        [XmlAttributeAttribute(true)]
        public Uri RelativeUri
        {
            get
            {
                return this._relativeUri;
            }
            set
            {
                if ((this._relativeUri != value))
                {
                    Uri old = this._relativeUri;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRelativeUriChanging(e);
                    this.OnPropertyChanging("RelativeUri", e, _relativeUriAttribute);
                    this._relativeUri = value;
                    this.OnRelativeUriChanged(e);
                    this.OnPropertyChanged("RelativeUri", e, _relativeUriAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Extensions property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("ExtendedElement")]
        [ConstantAttribute()]
        public ICollectionExpression<NMF.Models.IModelElementExtension> Extensions
        {
            get
            {
                return this._extensions;
            }
        }
        
        /// <summary>
        /// The Parent property
        /// </summary>
        [CategoryAttribute("ModelElement")]
        [XmlAttributeAttribute(true)]
        public NMF.Models.IModelElement Parent
        {
            get
            {
                return this._parent;
            }
            set
            {
                if ((this._parent != value))
                {
                    NMF.Models.IModelElement old = this._parent;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnParentChanging(e);
                    this.OnPropertyChanging("Parent", e, _parentReference);
                    this._parent = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetParent;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetParent;
                    }
                    this.OnParentChanged(e);
                    this.OnPropertyChanged("Parent", e, _parentReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new ModelElementChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<NMF.Models.IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ModelElementReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets fired before the AbsoluteUri property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AbsoluteUriChanging;
        
        /// <summary>
        /// Gets fired when the AbsoluteUri property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AbsoluteUriChanged;
        
        /// <summary>
        /// Gets fired before the RelativeUri property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RelativeUriChanging;
        
        /// <summary>
        /// Gets fired when the RelativeUri property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RelativeUriChanged;
        
        /// <summary>
        /// Gets fired before the Parent property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ParentChanging;
        
        /// <summary>
        /// Gets fired when the Parent property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ParentChanged;
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public abstract IClass GetClass();
        
        private static ITypedElement RetrieveAbsoluteUriAttribute()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(NMF.Models.ModelElement.ClassInstance)).Resolve("AbsoluteUri")));
        }
        
        /// <summary>
        /// Raises the AbsoluteUriChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAbsoluteUriChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AbsoluteUriChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AbsoluteUriChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAbsoluteUriChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AbsoluteUriChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveRelativeUriAttribute()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(NMF.Models.ModelElement.ClassInstance)).Resolve("RelativeUri")));
        }
        
        /// <summary>
        /// Raises the RelativeUriChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRelativeUriChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RelativeUriChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RelativeUriChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRelativeUriChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RelativeUriChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveExtensionsReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(NMF.Models.ModelElement.ClassInstance)).Resolve("Extensions")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Extensions property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ExtensionsCollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Extensions", e, _extensionsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Extensions property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ExtensionsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Extensions", e, _extensionsReference);
        }
        
        private static ITypedElement RetrieveParentReference()
        {
            return ((ITypedElement)(((NMF.Models.ModelElement)(NMF.Models.ModelElement.ClassInstance)).Resolve("Parent")));
        }
        
        /// <summary>
        /// Raises the ParentChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParentChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ParentChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ParentChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParentChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ParentChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Parent property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetParent(object sender, System.EventArgs eventArgs)
        {
            this.Parent = null;
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override NMF.Models.IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "PARENT"))
            {
                return this.Parent;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "ABSOLUTEURI"))
            {
                return this.AbsoluteUri;
            }
            if ((attribute == "RELATIVEURI"))
            {
                return this.RelativeUri;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "EXTENSIONS"))
            {
                return this._extensions;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "PARENT"))
            {
                this.Parent = ((NMF.Models.IModelElement)(value));
                return;
            }
            if ((feature == "ABSOLUTEURI"))
            {
                this.AbsoluteUri = ((Uri)(value));
                return;
            }
            if ((feature == "RELATIVEURI"))
            {
                this.RelativeUri = ((Uri)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "ABSOLUTEURI"))
            {
                return Observable.Box(new AbsoluteUriProxy(this));
            }
            if ((attribute == "RELATIVEURI"))
            {
                return Observable.Box(new RelativeUriProxy(this));
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "PARENT"))
            {
                return new ParentProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._extensions))
            {
                return "Extensions";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ModelElement class
        /// </summary>
        public class ModelElementChildrenCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private ModelElement _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ModelElementChildrenCollection(ModelElement parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.Extensions.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Extensions.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Extensions.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                IModelElementExtension extensionsCasted = item.As<IModelElementExtension>();
                if ((extensionsCasted != null))
                {
                    this._parent.Extensions.Add(extensionsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Extensions.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if (this._parent.Extensions.Contains(item))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(NMF.Models.IModelElement[] array, int arrayIndex)
            {
                IEnumerator<NMF.Models.IModelElement> extensionsEnumerator = this._parent.Extensions.GetEnumerator();
                try
                {
                    for (
                    ; extensionsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = extensionsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    extensionsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                IModelElementExtension modelElementExtensionItem = item.As<IModelElementExtension>();
                if (((modelElementExtensionItem != null) 
                            && this._parent.Extensions.Remove(modelElementExtensionItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<NMF.Models.IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Extensions).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ModelElement class
        /// </summary>
        public class ModelElementReferencedElementsCollection : ReferenceCollection, ICollectionExpression<NMF.Models.IModelElement>, ICollection<NMF.Models.IModelElement>
        {
            
            private ModelElement _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ModelElementReferencedElementsCollection(ModelElement parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.Extensions.Count);
                    if ((this._parent.Parent != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Extensions.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ParentChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Extensions.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ParentChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(NMF.Models.IModelElement item)
            {
                IModelElementExtension extensionsCasted = item.As<IModelElementExtension>();
                if ((extensionsCasted != null))
                {
                    this._parent.Extensions.Add(extensionsCasted);
                }
                if ((this._parent.Parent == null))
                {
                    IModelElement parentCasted = item.As<IModelElement>();
                    if ((parentCasted != null))
                    {
                        this._parent.Parent = parentCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Extensions.Clear();
                this._parent.Parent = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if (this._parent.Extensions.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Parent))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(NMF.Models.IModelElement[] array, int arrayIndex)
            {
                IEnumerator<NMF.Models.IModelElement> extensionsEnumerator = this._parent.Extensions.GetEnumerator();
                try
                {
                    for (
                    ; extensionsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = extensionsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    extensionsEnumerator.Dispose();
                }
                if ((this._parent.Parent != null))
                {
                    array[arrayIndex] = this._parent.Parent;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                IModelElementExtension modelElementExtensionItem = item.As<IModelElementExtension>();
                if (((modelElementExtensionItem != null) 
                            && this._parent.Extensions.Remove(modelElementExtensionItem)))
                {
                    return true;
                }
                if ((this._parent.Parent == item))
                {
                    this._parent.Parent = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<NMF.Models.IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<NMF.Models.IModelElement>().Concat(this._parent.Extensions).Concat(this._parent.Parent).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the AbsoluteUri property
        /// </summary>
        private sealed class AbsoluteUriProxy : ModelPropertyChange<NMF.Models.IModelElement, Uri>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AbsoluteUriProxy(NMF.Models.IModelElement modelElement) : 
                    base(modelElement, "AbsoluteUri")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Uri Value
            {
                get
                {
                    return this.ModelElement.AbsoluteUri;
                }
                set
                {
                    this.ModelElement.AbsoluteUri = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the RelativeUri property
        /// </summary>
        private sealed class RelativeUriProxy : ModelPropertyChange<NMF.Models.IModelElement, Uri>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RelativeUriProxy(NMF.Models.IModelElement modelElement) : 
                    base(modelElement, "RelativeUri")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Uri Value
            {
                get
                {
                    return this.ModelElement.RelativeUri;
                }
                set
                {
                    this.ModelElement.RelativeUri = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Parent property
        /// </summary>
        private sealed class ParentProxy : ModelPropertyChange<NMF.Models.IModelElement, NMF.Models.IModelElement>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ParentProxy(NMF.Models.IModelElement modelElement) : 
                    base(modelElement, "Parent")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.IModelElement Value
            {
                get
                {
                    return this.ModelElement.Parent;
                }
                set
                {
                    this.ModelElement.Parent = value;
                }
            }
        }
    }
}

