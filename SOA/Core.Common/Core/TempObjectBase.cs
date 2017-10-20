using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Core
{
    public class TempObjectBase : INotifyPropertyChanged
    {
        #region This Code eliminates the need to include -= on event subscription

        private event PropertyChangedEventHandler _PropertyChanged;

        // Create list to keep track of event subscribers
        List<PropertyChangedEventHandler> _PropertyChangedSubscribers
            = new List<PropertyChangedEventHandler>();

        public event PropertyChangedEventHandler PropertyChanged
        {

            add
            {
                if (!_PropertyChangedSubscribers.Contains(value))
                {
                    _PropertyChanged += value;
                    _PropertyChangedSubscribers.Add(value);
                }
            }
            remove
            {
                _PropertyChanged -= value;
                _PropertyChangedSubscribers.Remove(value);
            }
        }
        #endregion


        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (_PropertyChanged != null)
                _PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(string propertyName, bool makeDirty)
        {
            if (_PropertyChanged != null)
                _PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            if (makeDirty)
                _IsDirty = true;
        }


        bool _IsDirty;

        public bool IsDirty
        {
            get { return _IsDirty; }
        }


        //protected List<TempObjectBase> GetDirtyObjects()
        //{
        //    var dirtyObjects = new List<TempObjectBase>();

        //    var visited = new List<TempObjectBase>();

        //    Action<TempObjectBase> walk = null;

        //    walk = (o) =>
        //    {
        //        if (o != null && !visited.Contains(o))
        //        {
        //            visited.Add(o);

        //            if (o.IsDirty)
        //                dirtyObjects.Add(o);

        //            bool exitWalk = false;


        //            // walker functionality
        //            if (!exitWalk)
        //            {
        //                PropertyInfo[] properties = o.GetBrowsableProperties();
        //                foreach (PropertyInfo property in properties)
        //                {
        //                    if (property.PropertyType.IsSubclassOf(typeof(TempObjectBase)))
        //                    {
        //                        TempObjectBase obj = (TempObjectBase)(property.GetValue(o, null));

        //                        walk(obj);
        //                    }
        //                    else
        //                    {
        //                        IList collection = property.GetValue(o, null) as IList;
        //                        if (collection != null)
        //                        {
        //                            // don't do anything with collection specifically

        //                            foreach (object item in collection)
        //                            {
        //                                if (item is TempObjectBase)
        //                                {
        //                                    walk((TempObjectBase)item);
        //                                }
        //                            }
        //                        }

        //                    }
        //                }
        //            }
        //        }
        //    };

        //    walk(this);

        //    return dirtyObjects;
        //}
}
}
