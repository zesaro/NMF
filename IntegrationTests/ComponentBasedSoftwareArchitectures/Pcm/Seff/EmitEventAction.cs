//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Identifier;
using NMFExamples.Pcm.Core;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Reliability;
using NMFExamples.Pcm.Repository;
using NMFExamples.Pcm.Seff.Seff_performance;
using NMFExamples.Pcm.Seff.Seff_reliability;
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
using global::System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.Pcm.Seff
{
    
    
    /// <summary>
    /// The default implementation of the EmitEventAction class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/SEFF/5.0")]
    [XmlNamespacePrefixAttribute("seff")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/EmitEventAction")]
    [DebuggerDisplayAttribute("EmitEventAction {Id}")]
    public partial class EmitEventAction : AbstractAction, IEmitEventAction, IModelElement
    {
        
        private static Lazy<ITypedElement> _eventType__EmitEventActionReference = new Lazy<ITypedElement>(RetrieveEventType__EmitEventActionReference);
        
        /// <summary>
        /// The backing field for the EventType__EmitEventAction property
        /// </summary>
        private IEventType _eventType__EmitEventAction;
        
        private static Lazy<ITypedElement> _sourceRole__EmitEventActionReference = new Lazy<ITypedElement>(RetrieveSourceRole__EmitEventActionReference);
        
        /// <summary>
        /// The backing field for the SourceRole__EmitEventAction property
        /// </summary>
        private ISourceRole _sourceRole__EmitEventAction;
        
        private static Lazy<ITypedElement> _inputVariableUsages__CallActionReference = new Lazy<ITypedElement>(RetrieveInputVariableUsages__CallActionReference);
        
        /// <summary>
        /// The backing field for the InputVariableUsages__CallAction property
        /// </summary>
        private CallActionInputVariableUsages__CallActionCollection _inputVariableUsages__CallAction;
        
        private static IClass _classInstance;
        
        public EmitEventAction()
        {
            this._inputVariableUsages__CallAction = new CallActionInputVariableUsages__CallActionCollection(this);
            this._inputVariableUsages__CallAction.CollectionChanging += this.InputVariableUsages__CallActionCollectionChanging;
            this._inputVariableUsages__CallAction.CollectionChanged += this.InputVariableUsages__CallActionCollectionChanged;
        }
        
        /// <summary>
        /// The eventType__EmitEventAction property
        /// </summary>
        [XmlElementNameAttribute("eventType__EmitEventAction")]
        [XmlAttributeAttribute(true)]
        public IEventType EventType__EmitEventAction
        {
            get
            {
                return this._eventType__EmitEventAction;
            }
            set
            {
                if ((this._eventType__EmitEventAction != value))
                {
                    IEventType old = this._eventType__EmitEventAction;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEventType__EmitEventActionChanging(e);
                    this.OnPropertyChanging("EventType__EmitEventAction", e, _eventType__EmitEventActionReference);
                    this._eventType__EmitEventAction = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetEventType__EmitEventAction;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetEventType__EmitEventAction;
                    }
                    this.OnEventType__EmitEventActionChanged(e);
                    this.OnPropertyChanged("EventType__EmitEventAction", e, _eventType__EmitEventActionReference);
                }
            }
        }
        
        /// <summary>
        /// The sourceRole__EmitEventAction property
        /// </summary>
        [XmlElementNameAttribute("sourceRole__EmitEventAction")]
        [XmlAttributeAttribute(true)]
        public ISourceRole SourceRole__EmitEventAction
        {
            get
            {
                return this._sourceRole__EmitEventAction;
            }
            set
            {
                if ((this._sourceRole__EmitEventAction != value))
                {
                    ISourceRole old = this._sourceRole__EmitEventAction;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSourceRole__EmitEventActionChanging(e);
                    this.OnPropertyChanging("SourceRole__EmitEventAction", e, _sourceRole__EmitEventActionReference);
                    this._sourceRole__EmitEventAction = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetSourceRole__EmitEventAction;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetSourceRole__EmitEventAction;
                    }
                    this.OnSourceRole__EmitEventActionChanged(e);
                    this.OnPropertyChanged("SourceRole__EmitEventAction", e, _sourceRole__EmitEventActionReference);
                }
            }
        }
        
        /// <summary>
        /// The inputVariableUsages__CallAction property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("inputVariableUsages__CallAction")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("callAction__VariableUsage")]
        [ConstantAttribute()]
        public IListExpression<IVariableUsage> InputVariableUsages__CallAction
        {
            get
            {
                return this._inputVariableUsages__CallAction;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new EmitEventActionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new EmitEventActionReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/EmitEventAction")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the EventType__EmitEventAction property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> EventType__EmitEventActionChanging;
        
        /// <summary>
        /// Gets fired when the EventType__EmitEventAction property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> EventType__EmitEventActionChanged;
        
        /// <summary>
        /// Gets fired before the SourceRole__EmitEventAction property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> SourceRole__EmitEventActionChanging;
        
        /// <summary>
        /// Gets fired when the SourceRole__EmitEventAction property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> SourceRole__EmitEventActionChanged;
        
        private static ITypedElement RetrieveEventType__EmitEventActionReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Seff.EmitEventAction.ClassInstance)).Resolve("eventType__EmitEventAction")));
        }
        
        /// <summary>
        /// Raises the EventType__EmitEventActionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEventType__EmitEventActionChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.EventType__EmitEventActionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EventType__EmitEventActionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEventType__EmitEventActionChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.EventType__EmitEventActionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the EventType__EmitEventAction property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetEventType__EmitEventAction(object sender, global::System.EventArgs eventArgs)
        {
            this.EventType__EmitEventAction = null;
        }
        
        private static ITypedElement RetrieveSourceRole__EmitEventActionReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Seff.EmitEventAction.ClassInstance)).Resolve("sourceRole__EmitEventAction")));
        }
        
        /// <summary>
        /// Raises the SourceRole__EmitEventActionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSourceRole__EmitEventActionChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.SourceRole__EmitEventActionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the SourceRole__EmitEventActionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSourceRole__EmitEventActionChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.SourceRole__EmitEventActionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the SourceRole__EmitEventAction property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSourceRole__EmitEventAction(object sender, global::System.EventArgs eventArgs)
        {
            this.SourceRole__EmitEventAction = null;
        }
        
        private static ITypedElement RetrieveInputVariableUsages__CallActionReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Seff.CallAction.ClassInstance)).Resolve("inputVariableUsages__CallAction")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the InputVariableUsages__CallAction property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InputVariableUsages__CallActionCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("InputVariableUsages__CallAction", e, _inputVariableUsages__CallActionReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the InputVariableUsages__CallAction property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InputVariableUsages__CallActionCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("InputVariableUsages__CallAction", e, _inputVariableUsages__CallActionReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int inputVariableUsages__CallActionIndex = ModelHelper.IndexOfReference(this.InputVariableUsages__CallAction, element);
            if ((inputVariableUsages__CallActionIndex != -1))
            {
                return ModelHelper.CreatePath("inputVariableUsages__CallAction", inputVariableUsages__CallActionIndex);
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "INPUTVARIABLEUSAGES__CALLACTION"))
            {
                if ((index < this.InputVariableUsages__CallAction.Count))
                {
                    return this.InputVariableUsages__CallAction[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override global::System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "INPUTVARIABLEUSAGES__CALLACTION"))
            {
                return this._inputVariableUsages__CallAction;
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
            if ((feature == "EVENTTYPE__EMITEVENTACTION"))
            {
                this.EventType__EmitEventAction = ((IEventType)(value));
                return;
            }
            if ((feature == "SOURCEROLE__EMITEVENTACTION"))
            {
                this.SourceRole__EmitEventAction = ((ISourceRole)(value));
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
            if ((attribute == "EventType__EmitEventAction"))
            {
                return new EventType__EmitEventActionProxy(this);
            }
            if ((attribute == "SourceRole__EmitEventAction"))
            {
                return new SourceRole__EmitEventActionProxy(this);
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
            if ((reference == "EventType__EmitEventAction"))
            {
                return new EventType__EmitEventActionProxy(this);
            }
            if ((reference == "SourceRole__EmitEventAction"))
            {
                return new SourceRole__EmitEventActionProxy(this);
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
            if ((container == this._inputVariableUsages__CallAction))
            {
                return "inputVariableUsages__CallAction";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/EmitEventAction")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EmitEventAction class
        /// </summary>
        public class EmitEventActionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EmitEventAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EmitEventActionChildrenCollection(EmitEventAction parent)
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
                    count = (count + this._parent.InputVariableUsages__CallAction.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InputVariableUsages__CallAction.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InputVariableUsages__CallAction.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IVariableUsage inputVariableUsages__CallActionCasted = item.As<IVariableUsage>();
                if ((inputVariableUsages__CallActionCasted != null))
                {
                    this._parent.InputVariableUsages__CallAction.Add(inputVariableUsages__CallActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InputVariableUsages__CallAction.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.InputVariableUsages__CallAction.Contains(item))
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
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> inputVariableUsages__CallActionEnumerator = this._parent.InputVariableUsages__CallAction.GetEnumerator();
                try
                {
                    for (
                    ; inputVariableUsages__CallActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = inputVariableUsages__CallActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    inputVariableUsages__CallActionEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IVariableUsage variableUsageItem = item.As<IVariableUsage>();
                if (((variableUsageItem != null) 
                            && this._parent.InputVariableUsages__CallAction.Remove(variableUsageItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InputVariableUsages__CallAction).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EmitEventAction class
        /// </summary>
        public class EmitEventActionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EmitEventAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EmitEventActionReferencedElementsCollection(EmitEventAction parent)
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
                    if ((this._parent.EventType__EmitEventAction != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.SourceRole__EmitEventAction != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.InputVariableUsages__CallAction.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EventType__EmitEventActionChanged += this.PropagateValueChanges;
                this._parent.SourceRole__EmitEventActionChanged += this.PropagateValueChanges;
                this._parent.InputVariableUsages__CallAction.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EventType__EmitEventActionChanged -= this.PropagateValueChanges;
                this._parent.SourceRole__EmitEventActionChanged -= this.PropagateValueChanges;
                this._parent.InputVariableUsages__CallAction.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.EventType__EmitEventAction == null))
                {
                    IEventType eventType__EmitEventActionCasted = item.As<IEventType>();
                    if ((eventType__EmitEventActionCasted != null))
                    {
                        this._parent.EventType__EmitEventAction = eventType__EmitEventActionCasted;
                        return;
                    }
                }
                if ((this._parent.SourceRole__EmitEventAction == null))
                {
                    ISourceRole sourceRole__EmitEventActionCasted = item.As<ISourceRole>();
                    if ((sourceRole__EmitEventActionCasted != null))
                    {
                        this._parent.SourceRole__EmitEventAction = sourceRole__EmitEventActionCasted;
                        return;
                    }
                }
                IVariableUsage inputVariableUsages__CallActionCasted = item.As<IVariableUsage>();
                if ((inputVariableUsages__CallActionCasted != null))
                {
                    this._parent.InputVariableUsages__CallAction.Add(inputVariableUsages__CallActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EventType__EmitEventAction = null;
                this._parent.SourceRole__EmitEventAction = null;
                this._parent.InputVariableUsages__CallAction.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.EventType__EmitEventAction))
                {
                    return true;
                }
                if ((item == this._parent.SourceRole__EmitEventAction))
                {
                    return true;
                }
                if (this._parent.InputVariableUsages__CallAction.Contains(item))
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
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.EventType__EmitEventAction != null))
                {
                    array[arrayIndex] = this._parent.EventType__EmitEventAction;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.SourceRole__EmitEventAction != null))
                {
                    array[arrayIndex] = this._parent.SourceRole__EmitEventAction;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> inputVariableUsages__CallActionEnumerator = this._parent.InputVariableUsages__CallAction.GetEnumerator();
                try
                {
                    for (
                    ; inputVariableUsages__CallActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = inputVariableUsages__CallActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    inputVariableUsages__CallActionEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.EventType__EmitEventAction == item))
                {
                    this._parent.EventType__EmitEventAction = null;
                    return true;
                }
                if ((this._parent.SourceRole__EmitEventAction == item))
                {
                    this._parent.SourceRole__EmitEventAction = null;
                    return true;
                }
                IVariableUsage variableUsageItem = item.As<IVariableUsage>();
                if (((variableUsageItem != null) 
                            && this._parent.InputVariableUsages__CallAction.Remove(variableUsageItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EventType__EmitEventAction).Concat(this._parent.SourceRole__EmitEventAction).Concat(this._parent.InputVariableUsages__CallAction).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the eventType__EmitEventAction property
        /// </summary>
        private sealed class EventType__EmitEventActionProxy : ModelPropertyChange<IEmitEventAction, IEventType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EventType__EmitEventActionProxy(IEmitEventAction modelElement) : 
                    base(modelElement, "eventType__EmitEventAction")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IEventType Value
            {
                get
                {
                    return this.ModelElement.EventType__EmitEventAction;
                }
                set
                {
                    this.ModelElement.EventType__EmitEventAction = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the sourceRole__EmitEventAction property
        /// </summary>
        private sealed class SourceRole__EmitEventActionProxy : ModelPropertyChange<IEmitEventAction, ISourceRole>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SourceRole__EmitEventActionProxy(IEmitEventAction modelElement) : 
                    base(modelElement, "sourceRole__EmitEventAction")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISourceRole Value
            {
                get
                {
                    return this.ModelElement.SourceRole__EmitEventAction;
                }
                set
                {
                    this.ModelElement.SourceRole__EmitEventAction = value;
                }
            }
        }
    }
}
