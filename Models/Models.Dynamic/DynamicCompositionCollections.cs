﻿using System;
using System.Collections.Generic;
using System.Text;
using NMF.Models.Collections;
using NMF.Models.Meta;

namespace NMF.Models.Dynamic
{
    internal class DynamicCompositionList : CompositionList<IModelElement>
    {
        public DynamicCompositionList(ModelElement parent, IClass type) : base(parent)
        {
            Type = type;
        }
        public IClass Type { get; }

        protected override void InsertItem(int index, IModelElement item)
        {
            if (item != null && !Type.IsAssignableFrom(item.GetClass()))
            {
                throw new InvalidOperationException($"Cannot cast element of type {item.GetClass().Name} to {Type.Name}.");
            }
            base.InsertItem(index, item);
        }

        protected override void SetItem(int index, IModelElement item)
        {
            if (item != null && !Type.IsAssignableFrom(item.GetClass()))
            {
                throw new InvalidOperationException($"Cannot cast element of type {item.GetClass().Name} to {Type.Name}.");
            }
            base.SetItem(index, item);
        }
    }

    internal class DynamicCompositionOrderedSet : CompositionOrderedSet<IModelElement>
    {
        public IClass Type { get; }

        public DynamicCompositionOrderedSet(ModelElement parent, IClass type) : base(parent)
        {
            Type = type;
        }

        public override void Insert(int index, IModelElement item)
        {
            if (item != null && !Type.IsAssignableFrom(item.GetClass()))
            {
                throw new InvalidOperationException($"Cannot cast element of type {item.GetClass().Name} to {Type.Name}.");
            }
            base.Insert(index, item);
        }

        protected override void Replace(int index, IModelElement oldValue, IModelElement newValue)
        {
            if (newValue != null && !Type.IsAssignableFrom(newValue.GetClass()))
            {
                throw new InvalidOperationException($"Cannot cast element of type {newValue.GetClass().Name} to {Type.Name}.");
            }
            base.Replace(index, oldValue, newValue);
        }
    }

    internal class DynamicCompositionSet : CompositionSet<IModelElement>
    {
        public IClass Type { get; }

        public DynamicCompositionSet(ModelElement parent, IClass type) : base(parent)
        {
            Type = type;
        }

        public override bool Add(IModelElement item)
        {
            if (item != null && !Type.IsAssignableFrom(item.GetClass()))
            {
                throw new InvalidOperationException($"Cannot cast element of type {item.GetClass().Name} to {Type.Name}.");
            }
            return base.Add(item);
        }
    }
}
