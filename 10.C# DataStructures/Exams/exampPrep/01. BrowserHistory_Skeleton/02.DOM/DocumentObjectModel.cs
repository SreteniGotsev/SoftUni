namespace _02.DOM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _02.DOM.Interfaces;
    using _02.DOM.Models;

    public class DocumentObjectModel : IDocument
    {
        List<IHtmlElement> elements = new List<IHtmlElement>();

        public DocumentObjectModel(IHtmlElement root)
        {
            this.Root = root;
        }

        public DocumentObjectModel()
        {
            this.Root = new HtmlElement(ElementType.Document, new HtmlElement(ElementType.Html, new HtmlElement(ElementType.Head), new HtmlElement(ElementType.Body)));
        }

        public IHtmlElement Root { get; private set; }

        public IHtmlElement GetElementByType(ElementType type)
        {

            return TypeBFS(Root, type);


        }

        public IHtmlElement TypeBFS(IHtmlElement root, ElementType type)
        {
            Queue<IHtmlElement> queue = new Queue<IHtmlElement>();


            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();

                if (item.Type == type)
                {
                    return item;
                }
                foreach (var element in item.Children)
                {
                    queue.Enqueue(element);
                }
            }

            return null;
        }

        public List<IHtmlElement> GetElementsByType(ElementType type)
        {
            DFSList(type, this.Root);
            return elements;
        }

        private void DFSList(ElementType type, IHtmlElement root)
        {
            foreach (var child in root.Children)
            {
                DFSList(type, child);

                if (child.Type == type)
                {
                    elements.Add(child);
                }

            }
        }

        public void InsertFirst(IHtmlElement parent, IHtmlElement child)
        {
            if (this.Contains(parent))
            {

            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void InsertLast(IHtmlElement parent, IHtmlElement child)
        {
            throw new NotImplementedException();
        }

        public void Remove(IHtmlElement htmlElement)
        {
            if (!this.Contains(htmlElement))
            {
                throw new InvalidOperationException();
            }


            DeleteNode(this.Root, htmlElement);



        }

        public void DeleteNode(IHtmlElement root, IHtmlElement element)
        {
            if (root == element.Parent)
            {
                root.Children.Remove(element);
                return;
            }
            else
            {
                foreach (var child in root.Children)
                {
                    DeleteNode(child, element);
                }
            }

        }

        public void RemoveAll(ElementType elementType)
        {
            RemoveAllDFS(elementType, this.Root);

        }

        public void RemoveAllDFS(ElementType type, IHtmlElement htmlElement)
        {

            foreach (var child in htmlElement.Children)
            {
                RemoveAllDFS(type, child);

                if (child.Type == type)
                {
                    Remove(child);
                    return;
                }

            }

        }

        public void DFSRemove(ElementType type, IHtmlElement element)
        {
            foreach (var child in element.Children)
            {
                DFSRemove(type, child);

                if (child.Type == type)
                {
                    this.Remove(child);
                }
            }
        }

        public bool AddAttribute(string attrKey, string attrValue, IHtmlElement htmlElement)
        {
            elements = BFSList(Root);
            if (!elements.Contains(htmlElement))
            {
                throw new InvalidOperationException();
            }

            int html = elements.IndexOf(htmlElement);

            if (!elements[html].Attributes.ContainsKey(attrKey))
            {
                elements[html].Attributes.Add(attrKey, attrValue);
                return true;
            }

            return false;

        }
        public List<IHtmlElement> BFSList(IHtmlElement root)
        {
            List<IHtmlElement> list = new List<IHtmlElement>();
            Queue<IHtmlElement> queue = new Queue<IHtmlElement>();


            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                list.Add(item);

                foreach (var element in item.Children)
                {
                    queue.Enqueue(element);
                }
            }

            return list;
        }

        public bool RemoveAttribute(string attrKey, IHtmlElement htmlElement)
        {
            elements = BFSList(Root);

            if (!elements.Contains(htmlElement))
            {
                throw new InvalidOperationException();
            }

            int html = elements.IndexOf(htmlElement);

            if (elements[html].Attributes.ContainsKey(attrKey))
            {
                elements[html].Attributes.Remove(attrKey);
                return true;
            }

            return false;

        }

        public IHtmlElement GetElementById(string idValue)
        {
            return IDBFS(Root, idValue);
        }

        private IHtmlElement IDBFS(IHtmlElement root, string idValue)

        {
            Queue<IHtmlElement> queue = new Queue<IHtmlElement>();


            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();

                if (item.Attributes.ContainsKey("id"))
                {
                    return item;
                }

                foreach (var element in item.Children)
                {
                    queue.Enqueue(element);
                }
            }

            return null;
        }

        public bool Contains(IHtmlElement htmlElement)
        {
            Queue<IHtmlElement> queue = new Queue<IHtmlElement>();


            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();

                if (item == htmlElement)
                {
                    return true;
                }

                foreach (var element in item.Children)
                {
                    queue.Enqueue(element);
                }
            }

            return false;
        }
    }
}
