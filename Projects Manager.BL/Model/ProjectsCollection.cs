using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects_Manager.Model
{
    public class ProjectsCollection : ICollection<Project>, INotifyCollectionChanged
    {
        List<Project> elements { get; }
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public ProjectsCollection()
        {
            elements = new List<Project>();
        }

        #region Fields

        public int Count
        {
            get { return elements.Count; }
        }
        public bool IsReadOnly { get; set; }

        #endregion

        #region Indexers

        public Project this[int i]
        {
            get
            {
                return elements[i];
            }
        }

        public Project this[string name]
        {
            get
            {
                return elements.Find(x => x.Name == name);
            }
        }
        #endregion

        #region Methods
        void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            CollectionChanged?.Invoke(this, e);
        }

        public void Add(Project item)
        {
            elements.Add(item);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
        }

        public void Clear()
        {
            elements.Clear();
        }

        public bool Contains(Project item)
        {
            return elements.Contains(item);
        }

        public void CopyTo(Project[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Project item)
        {
            var index = elements.IndexOf(item);
            if(elements.Remove(item))
            {
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
                return elements.Remove(item);
            }
            return false;
        }

        #endregion

        #region InterfacesIplementation

        public IEnumerator<Project> GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return elements.GetEnumerator();
        }
        #endregion
    }
}
